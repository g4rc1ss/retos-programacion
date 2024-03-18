$counter = 102

foreach ($currentItemName in 102..101) {
    $zero = ""
    if ($counter -clt 10) {
        $zero = "0"
    }
    New-Item -Path "Reto $zero$counter/Enunciado.md" -ItemType File -Force
    $counter++;
}