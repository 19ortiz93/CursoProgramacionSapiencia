Algoritmo sin_titulo
	// Leer un número ingresado por el usuario 
    //e imprimir si es un número primo o no es primo
	
	Definir num, acum Como Real;;
	
	Escribir "Ingrese un numero: ";
	Leer num;
	
	acum = 0;
	
	para i = 1 hasta num Con Paso 1 Hacer
		si num mod i == 0 Entonces
			acum = acum + 1;
		FinSi
	FinPara
	
	si acum == 2 Entonces
		Escribir "El número " num " es un número primo";
	SiNo
		Escribir "El número " num " no es un número primo";
	FinSi
FinAlgoritmo
