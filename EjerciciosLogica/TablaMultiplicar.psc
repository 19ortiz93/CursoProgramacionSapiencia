Algoritmo sin_titulo
	//hacer un algortimo que lea un numero ingresado por el usuario e imprima
    //la tabla de multiplicar
	
	Definir tabla, resultado Como Entero;
	
	Escribir "Ingrese el número de la tabla de multiplicar: ";
	Leer tabla;
	
	para i = 0 hasta 10 Con Paso 1 Hacer
		resultado = tabla * i;
		Escribir tabla " x " i " = " resultado;
	FinPara
FinAlgoritmo
