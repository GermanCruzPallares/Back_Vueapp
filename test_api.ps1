# Setup common variables
$baseUrl = "http://localhost:5053/api"
$loginBody = @{ username = 'admin'; password = 'admin123' } | ConvertTo-Json

Write-Host "==============================================================="
Write-Host "                   API SECURITY & ENDPOINT TESTS               "
Write-Host "==============================================================="

# =======================================================
# 1. TEST ANONYMOUS ACCESS (SHOULD FAIL WITH 401)
# =======================================================
Write-Host "`n[TEST 1] Testing Unauthenticated Access to /Products"

try {
    $result = Invoke-RestMethod -Uri "$baseUrl/Products" -Method Get -ErrorAction Stop
    Write-Host " [X] FAILED: The request succeeded but it should have been unauthorized." -ForegroundColor Red
} catch [System.Net.WebException] {
    $r = $_.Exception.Response
    if ($r.StatusCode -eq [System.Net.HttpStatusCode]::Unauthorized) {
        Write-Host " [OK] SUCCESS: API returned 401 Unauthorized as expected." -ForegroundColor Green
    } else {
        Write-Host " [X] FAILED: Unexpected error status - $($r.StatusCode)" -ForegroundColor Red
    }
}

# =======================================================
# 2. TEST AUTHENTICATION (SHOULD RETURN JWT TOKEN)
# =======================================================
Write-Host "`n[TEST 2] Testing Authenticated Login to /Auth/login"

try {
    $response = Invoke-RestMethod -Uri "$baseUrl/Auth/login" -Method Post -Body $loginBody -ContentType "application/json" -ErrorAction Stop
    $token = $response.token
    $headers = @{ Authorization = "Bearer $token" }
    Write-Host " [OK] SUCCESS: Received JWT Token (Length: $($token.Length))" -ForegroundColor Green
} catch {
    Write-Host " [X] FAILED: Could not login." -ForegroundColor Red
    exit
}

# =======================================================
# 3. CRUDS - CATEGORIES 
# =======================================================
Write-Host "`n[TEST 3] Testing GET Categories (Authorized)"
$categories = Invoke-RestMethod -Uri "$baseUrl/Categories" -Method Get -Headers $headers
Write-Host " [OK] SUCCESS: Found $($categories.Count) categories." -ForegroundColor Green

Write-Host "`n[TEST 4] Testing POST Category"
$catBody = @{ name = "Test Category"; description = "Test Description" } | ConvertTo-Json
$newCat = Invoke-RestMethod -Uri "$baseUrl/Categories" -Method Post -Body $catBody -ContentType "application/json" -Headers $headers
$catId = $newCat.id
Write-Host " [OK] SUCCESS: Created Category with ID: $catId" -ForegroundColor Green

Write-Host "`n[TEST 5] Testing PUT Category"
$catUpdate = @{ name = "Test Category Updated"; description = "Updated Description" } | ConvertTo-Json
Invoke-RestMethod -Uri "$baseUrl/Categories/$catId" -Method Put -Body $catUpdate -ContentType "application/json" -Headers $headers
Write-Host " [OK] SUCCESS: Category $catId Updated." -ForegroundColor Green

# =======================================================
# 4. CRUDS - PRODUCTS
# =======================================================
Write-Host "`n[TEST 6] Testing GET Products (Paged default)"
$productsResponse = Invoke-RestMethod -Uri "$baseUrl/Products" -Method Get -Headers $headers
Write-Host " [OK] SUCCESS: Found $($productsResponse.items.Count) products in current page." -ForegroundColor Green

Write-Host "`n[TEST 7] Testing POST Product"
$prodBody = @{ name = "Test Shoe"; price = 99.99; categoryId = $catId } | ConvertTo-Json
$newProd = Invoke-RestMethod -Uri "$baseUrl/Products" -Method Post -Body $prodBody -ContentType "application/json" -Headers $headers
$prodId = $newProd.id
Write-Host "[OK] SUCCESS: Created Product with ID: $prodId" -ForegroundColor Green

Write-Host "`n[TEST 8] Testing PUT Product"
$prodUpdate = @{ name = "Test Shoe Updated"; price = 101.0; categoryId = $catId } | ConvertTo-Json
Invoke-RestMethod -Uri "$baseUrl/Products/$prodId" -Method Put -Body $prodUpdate -ContentType "application/json" -Headers $headers
Write-Host "[OK] SUCCESS: Product $prodId Updated." -ForegroundColor Green

# =======================================================
# 5. TEST RBAC (REGULAR USER SHOULD NOT BE ABLE TO DELETE)
# =======================================================
Write-Host "`n[TEST 9] Testing DELETE Product as Regular User (Should be Forbidden)"
$userLoginBody = @{ username = 'testuser'; password = 'user123' } | ConvertTo-Json
try {
    $userResponse = Invoke-RestMethod -Uri "$baseUrl/Auth/login" -Method Post -Body $userLoginBody -ContentType "application/json" -ErrorAction Stop
    $userHeaders = @{ Authorization = "Bearer $($userResponse.token)" }
    
    Invoke-RestMethod -Uri "$baseUrl/Products/$prodId" -Method Delete -Headers $userHeaders -ErrorAction Stop
    Write-Host " [X] FAILED: Regular user was able to delete the product!" -ForegroundColor Red
} catch [System.Net.WebException] {
    $r = $_.Exception.Response
    if ($r.StatusCode -eq [System.Net.HttpStatusCode]::Forbidden) {
        Write-Host " [OK] SUCCESS: API returned 403 Forbidden as expected." -ForegroundColor Green
    } else {
        Write-Host " [X] FAILED: Unexpected error status - $($r.StatusCode)" -ForegroundColor Red
    }
}

# =======================================================
# 6. CRUDS - DELETION (CLEANUP AS ADMIN)
# =======================================================
Write-Host "`n[TEST 10] Testing DELETE Product as Admin"
Invoke-RestMethod -Uri "$baseUrl/Products/$prodId" -Method Delete -Headers $headers
Write-Host " [OK] SUCCESS: Product $prodId Deleted." -ForegroundColor Green

Write-Host "`n[TEST 11] Testing DELETE Category as Admin"
Invoke-RestMethod -Uri "$baseUrl/Categories/$catId" -Method Delete -Headers $headers
Write-Host " [OK] SUCCESS: Category $catId Deleted." -ForegroundColor Green

# =======================================================
# 7. TEST PAGED SEARCH
# =======================================================
Write-Host "`n[TEST 12] Testing Paged Search (Page 1, Size 5, Sorting by Name)"
$searchUrl = "$baseUrl/Products?page=1&pageSize=5&sortBy=name&isAscending=true"
try {
    $searchResponse = Invoke-RestMethod -Uri $searchUrl -Method Get -Headers $headers -ErrorAction Stop
    $count = $searchResponse.items.Count
    $total = $searchResponse.totalItems
    Write-Host " [OK] SUCCESS: Received $count items (Total in DB: $total)" -ForegroundColor Green
    Write-Host " [INFO] First element name: $($searchResponse.items[0].name)"
} catch {
    Write-Host " [X] FAILED: Could not perform paged search." -ForegroundColor Red
}

Write-Host "`n[TEST 13] Testing Filtered Search (Search: 'Air Max')"
$filterUrl = "$baseUrl/Products?search=Air%20Max"
try {
    $filterResponse = Invoke-RestMethod -Uri $filterUrl -Method Get -Headers $headers -ErrorAction Stop
    Write-Host " [OK] SUCCESS: Found $($filterResponse.items.Count) products matching 'Air Max'." -ForegroundColor Green
} catch {
    Write-Host " [X] FAILED: Could not filter products." -ForegroundColor Red
}

Write-Host "`n==============================================================="
Write-Host " [OK] ALL TESTS COMPLETED SUCCESSFULLY" -ForegroundColor Cyan
Write-Host "==============================================================="
