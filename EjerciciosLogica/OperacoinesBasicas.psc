Algoritmo sin_titulo
	//Dados dos números, mostrar la suma, resta, 
	//división y multiplicación de ambos.
	Definir num1, num2, suma, resta, multiplicacion, division Como Real;
	//Entradas
	Escribir "Ingrese el primer número: ";
	Leer num1;
	Escribir "Ingrese el segundo número: ";
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
	Escribir "Multiplicación: "+ConvertirATexto(multiplicacion);
	Escribir "División: "+ConvertirATexto(division);
FinAlgoritmo
