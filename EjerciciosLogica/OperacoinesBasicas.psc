Algoritmo sin_titulo
	//Dados dos n�meros, mostrar la suma, resta, 
	//divisi�n y multiplicaci�n de ambos.
	Definir num1, num2, suma, resta, multiplicacion, division Como Real;
	//Entradas
	Escribir "Ingrese el primer n�mero: ";
	Leer num1;
	Escribir "Ingrese el segundo n�mero: ";
	Leer num2;
	//Proceso 
	suma = num1 + num2;
	resta = num1 - num2;
	multiplicacion = num1 * num2;
	si num2 == 0 Entonces
		Escribir "Error: no se puede dividir por cero (0)";
		division = 404;
	SiNo
		division = num1 / num2;
	FinSi
	//Salida
	Escribir "Suma: "+ConvertirATexto(suma);
	Escribir "Resta: "+ConvertirATexto(resta);
	Escribir "Multiplicaci�n: "+ConvertirATexto(multiplicacion);
	Escribir "Divisi�n: "+ConvertirATexto(division);
FinAlgoritmo
