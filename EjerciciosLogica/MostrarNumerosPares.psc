Algoritmo sin_titulo
	//Escribir un programa que imprima todos los números 
    //pares entre dos números que se le pidan al usuario.
	Definir num1, num2 Como Entero;
	
	Escribir "Ingrese el primer número: ";
	Leer num1;
	Escribir "Ingrese el segundo número: ";
	Leer num2;
	
	para i = num1 hasta num2 Con Paso 1 Hacer
		si i mod 2 == 0 Entonces
			Escribir Sin Saltar i " ";
		FinSi
	FinPara
FinAlgoritmo
