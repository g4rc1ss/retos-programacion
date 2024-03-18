param (
    [Parameter(Mandatory = $false)]
    [int]$NumCharacters = 16,

    [Parameter(Mandatory = $false)]
    [bool]$WithMayus = $true,

    [Parameter(Mandatory = $false)]
    [bool]$WithNumbers = $true,

    [Parameter(Mandatory = $false)]
    [bool]$WithSymbols = $true
)
# variables que contienen los simbolos, letras y numeros para crear la contraseña
$alphabetic = "abcdefghijklmnopqrstuvwxyz"
$alphabeticUpper = $alphabetic.ToUpper()
$symbols = "*^-.,¿?=)(/&%$!ª)_-.:,;{}"
$numbers = "0123456789"


$paramsPassBuilder = $alphabetic
if ($WithMayus) {
    $paramsPassBuilder += $alphabeticUpper
}
if ($WithNumbers) {
    $paramsPassBuilder += $numbers
}
if ($WithSymbols) {
    $paramsPassBuilder += $symbols
}

$randomChars = $paramsPassBuilder.ToCharArray()

# Generar un array de índices aleatorios
$randomChars = $randomChars | Get-Random -Count $randomChars.Count




$password = ""
for ($i = 0; $i -lt $NumCharacters; $i++) {
    $password += $randomChars | Get-Random
}

Write-Host $password
