Algoritmo sin_titulo
	Definir num1, num2, resultado Como Real;
	Definir opc Como Entero;
	
	Escribir "Ingrese el primer número: ";
	Leer num1;
	Escribir "Ingrese el segundo número: ";
	Leer num2;
	//menu
	Escribir "Escoja una opción matematica:";
	Escribir "1 -> Suma.";
	Escribir "2 -> Resta.";
	Escribir "3 -> Multiplicación.";
	Escribir "4 -> División.";
	Leer opc
	
	segun opc Hacer
		caso 1:
			resultado = num1 + num2;
			Escribir "la suma es: "+ConvertirATexto(resultado);
		caso 2:
			resultado = num1 - num2;
			Escribir "la resta es: "+ConvertirATexto(resultado);
		caso 3:
			resultado = num1 * num2;
			Escribir "la multiplicación es: "+ConvertirATexto(resultado);
		caso 4:
			si num2 == 0 Entonces
				Escribir "Error: no se puede dividir por cero (0)";
			SiNo
				resultado = num1 / num2;
				Escribir "la división es: "+ConvertirATexto(resultado);
			FinSi
	FinSegun
FinAlgoritmo
