Algoritmo sin_titulo
	//Escribir un programa que imprima todos los n�meros 
    //pares entre dos n�meros que se le pidan al usuario.
	Definir num1, num2 Como Entero;
	
	Escribir "Ingrese el primer n�mero: ";
	Leer num1;
	Escribir "Ingrese el segundo n�mero: ";
	Leer num2;
	
	para i = num1 hasta num2 Con Paso 1 Hacer
		si i mod 2 == 0 Entonces
			Escribir Sin Saltar i " ";
		FinSi
	FinPara
FinAlgoritmo
