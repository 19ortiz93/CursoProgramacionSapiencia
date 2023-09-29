Algoritmo sin_titulo
	//Un alumno desea saber cual será su calificación final 
	//en la materia de Algoritmos. Dicha calificación se compone 
	//de los siguientes porcentajes:
	//	55% del promedio de sus tres calificaciones parciales.
	//	30% de la calificación del examen final.
	//	15% de la calificación de un trabajo final.
	
	//Variables
	Definir notaParcial1, notaParcial2, notaParcial3, notaParciales Como Real;
	Definir notaExaFinal, notaTrabaFinal, notaFinal Como Real;
	//Entradas
	Escribir "Ingrese la nota del primer examen: ";
	Leer notaParcial1;
	Escribir "Ingrese la nota del segundo examen: ";
	Leer notaParcial2;
	Escribir "Ingrese la nota del tercer examen: ";
	Leer notaParcial3;
	Escribir "Ingrese la nota del examen final: ";
	Leer notaExaFinal;
	Escribir "Ingrese la nota del trabajo final: ";
	Leer notaTrabaFinal;
	//Proceso
	notaParciales = (notaParcial1+notaParcial2+notaParcial3)/3;
	notaFinal = (notaParciales * 0.55) + (notaExaFinal * 0.30) + (notaTrabaFinal * 0.15);
	//Mostrar
	Escribir "su nota final del curso es: " + ConvertirATexto(notaFinal);
FinAlgoritmo
