Algoritmo sin_titulo
	//Hacer un algoritmo que lea un numero ingresado por el
	//usuario e imprima su factorial
	
	Definir numFactorial, resultado Como Real;
	
	Escribir "Ingrese un número par calcular el factorial: ";
	Leer numFactorial;
	resultado = 1;
	
	para i = 1 Hasta numFactorial Con Paso 1 Hacer
		resultado = resultado * i;
	FinPara
	
	Escribir "El resultado factorial de " numFactorial " es: " resultado; 
FinAlgoritmo
