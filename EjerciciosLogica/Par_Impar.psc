Algoritmo sin_titulo
	//Pedir un valor num�rico e indicar si es par o no es par.
	
	Definir num Como Real;
	
	Escribir "Ingrese un n�mero: ";
	Leer num;
	
	si num MOD 2 = 0 Entonces
		Escribir "El n�mero "+ConvertirATexto(num)+" es PAR";
	SiNo
		Escribir "El n�mero "+ConvertirATexto(num)+" es IMPAR";
	FinSi
FinAlgoritmo
