Algoritmo sin_titulo
	// Leer un n�mero ingresado por el usuario 
    //e imprimir si es un n�mero primo o no es primo
	
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
		Escribir "El n�mero " num " es un n�mero primo";
	SiNo
		Escribir "El n�mero " num " no es un n�mero primo";
	FinSi
FinAlgoritmo
