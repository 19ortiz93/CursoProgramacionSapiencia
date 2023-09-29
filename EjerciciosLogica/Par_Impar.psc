Algoritmo sin_titulo
	//Pedir un valor numérico e indicar si es par o no es par.
	
	Definir num Como Real;
	
	Escribir "Ingrese un número: ";
	Leer num;
	
	si num MOD 2 = 0 Entonces
		Escribir "El número "+ConvertirATexto(num)+" es PAR";
	SiNo
		Escribir "El número "+ConvertirATexto(num)+" es IMPAR";
	FinSi
FinAlgoritmo
