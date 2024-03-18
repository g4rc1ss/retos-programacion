package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func main() {
	scanner := bufio.NewScanner(os.Stdin)

	fmt.Println("Inserta un numero")
	scanner.Scan()

	text := scanner.Text()
	numero, error := strconv.Atoi(text)

	if error != nil {
		fmt.Println("Error al convertir el string a entero:", error)
	}

	fmt.Printf("%d %s", numero, comprobacionNumero(numero))
}

func comprobacionNumero(number int) string {
	var responseText string

	if esPrimo(number) {
		responseText += " es primo"
	} else {
		responseText += " no es primo"
	}

	if esFibonacci(number) {
		responseText += ", es fibonacci "
	} else {
		responseText += ", no es fibonacci "
	}

	if number%2 == 0 {
		responseText += "y es par"
	} else {
		responseText += "y es impar"
	}
	return responseText
}

func esPrimo(numero int) bool {
	var divisores int = 0
	for i := 1; i < numero+1; i++ {
		if numero%i == 0 {
			divisores++
			if divisores > 2 {
				break
			}
		}
	}
	return divisores == 2
}

func esFibonacci(numero int) bool {
	var v1 int = 0
	var v2 int = 1

	for i := 0; i < numero+1; i++ {
		//Almacenamos el valor v1 en una variable temporal para no perderlo.
		var temp int = v1

		//El valor 1 se convierte en el valor 2.
		v1 = v2

		//Sumamos los valores.
		v2 = temp + v1

		if v2 == numero {
			return true
		}
	}

	return false
}
