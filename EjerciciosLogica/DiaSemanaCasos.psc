Algoritmo sin_titulo
	//Leer un n�mero ingresado por el usuario de 1 al 7, debe evaluar
	//si el n�mero es 1 mostrar "D�a Lunes", si el n�mero es 2 mostrar "D�a Martes",
	//si el n�mero es 3 mostrar "D�a Mi�rcoles", y as� hasta llegar el d�a Domingo
	//de lo contrario o de otro modo "no entro en ninguna opci�n"
	Definir dia Como Entero;
	
	Escribir "Ingrese el n�mero del d�a de la seman";
	Leer dia;
	
	segun dia Hacer //switch
		caso 1:
			Escribir "D�a Lunes";
			//breask;
		caso 2:
			Escribir "D�a Martes";
		caso 3:
			Escribir "D�a Mi�rcoles";
		caso 4:
			Escribir "D�a Jueves";
		caso 5:
			Escribir "D�a Viernes";
		caso 6:
			Escribir "D�a S�bado";
		caso 7:
			Escribir "D�a Domingo";
		De Otro Modo:
			Escribir "D�a no valido";
	FinSegun
FinAlgoritmo
