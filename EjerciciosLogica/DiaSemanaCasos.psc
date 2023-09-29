Algoritmo sin_titulo
	//Leer un número ingresado por el usuario de 1 al 7, debe evaluar
	//si el número es 1 mostrar "Día Lunes", si el número es 2 mostrar "Día Martes",
	//si el número es 3 mostrar "Día Miércoles", y así hasta llegar el día Domingo
	//de lo contrario o de otro modo "no entro en ninguna opción"
	Definir dia Como Entero;
	
	Escribir "Ingrese el número del día de la seman";
	Leer dia;
	
	segun dia Hacer //switch
		caso 1:
			Escribir "Día Lunes";
			//breask;
		caso 2:
			Escribir "Día Martes";
		caso 3:
			Escribir "Día Miércoles";
		caso 4:
			Escribir "Día Jueves";
		caso 5:
			Escribir "Día Viernes";
		caso 6:
			Escribir "Día Sábado";
		caso 7:
			Escribir "Día Domingo";
		De Otro Modo:
			Escribir "Día no valido";
	FinSegun
FinAlgoritmo
