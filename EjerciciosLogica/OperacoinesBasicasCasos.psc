Algoritmo sin_titulo
	Definir num1, num2, resultado Como Real;
	Definir opc Como Entero;
	
	Escribir "Ingrese el primer n�mero: ";
	Leer num1;
	Escribir "Ingrese el segundo n�mero: ";
	Leer num2;
	//menu
	Escribir "Escoja una opci�n matematica:";
	Escribir "1 -> Suma.";
	Escribir "2 -> Resta.";
	Escribir "3 -> Multiplicaci�n.";
	Escribir "4 -> Divisi�n.";
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
			Escribir "la multiplicaci�n es: "+ConvertirATexto(resultado);
		caso 4:
			si num2 == 0 Entonces
				Escribir "Error: no se puede dividir por cero (0)";
			SiNo
				resultado = num1 / num2;
				Escribir "la divisi�n es: "+ConvertirATexto(resultado);
			FinSi
	FinSegun
FinAlgoritmo
