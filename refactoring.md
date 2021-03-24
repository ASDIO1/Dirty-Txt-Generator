
# Laboratorio 1: Code Smells y Refactorizaci�n
Estudiante: Dussan Alejandro Freire Pozo <br>
En la siguiente lista se representan un conjunto de "code smells" del c�digo seleccionado.
# List of code smells:
## Code smell 1: 
	* L�nea/s del code smell: Toda la clase "Program.cs"
	* Tipo de code smell: Clase grande
	* Refactorizaci�n realizada: Se extrajeron m�ltiples clases que representen de manera modular y clara el proyecto
	* L�neas de refactorizaci�n: 
		Se generaron las siguientes clases para tener los m�todos de manera modular 
		* TextOrderExecutor
		* TextFileManager
		* ConsoleDisplayer
## Code smell 2: 
	* L�nea/s del code smell: 49-51, 114-116, 149-151 y 181-183
	* Tipo de code smell: C�digo duplicado
	* Refactorizaci�n realizada: Se extrajo el c�digo en un m�todo, llamado "displayErrorMessage"
	* L�neas de refactorizaci�n: Clase ConsoleDisplayer, l�nea 26
## Code smell 3: 
	* L�nea/s del code smell: 54-61, 119-126, 154-161 y 186-193
	* Tipo de code smell: C�digo duplicado
	* Refactorizaci�n realizada: Se extrajo el c�digo en un m�todo, llamado "displayFilesListAndMessage"
	* L�neas de refactorizaci�n: Clase ConsoleDisplayer, l�nea 31
## Code smell 4: 
	* L�nea/s del code smell: M�todo "Main" en "Program.cs"
	* Tipo de code smell: M�todo grande
	* Refactorizaci�n realizada: Se extrajeron m�ltiples m�todos y se los distribuyo en diferentes clases
	* L�neas de refactorizaci�n: 
		* Refactorizaci�n de acciones dentro de cada opci�n del switch:
			* Clase TextOrderExecutor, l�neas 11, 24, 38, 48, 56
		* Refactorizaci�n del men�: 
			* Clase TextFileManager, l�neas 43, 55 y 87
## Code smell 5: 
	* Linea/s del code smell: 204 
	* Tipo de code smell: "Uncommunicative Name" (Referencia: https://apiumhub.com/tech-blog-barcelona/code-smells/ )
	* Refactorizaci�n realizada: Se cambio el nombre de la variable a una m�s entendible
	* L�neas de refactorizaci�n: Clase ConsoleDisplayer, l�nea 42
## Code smell 6:
	* Linea/s del code smell: 205
	* Tipo de code smell: Condicional negativo
	* Refactorizaci�n realizada: Se creo una funci�n que valide la variable en el loop
	* L�neas de refactorizaci�n: Clase ConsoleDisplayer, l�nea 47 y 50
## Code smell 7:
	* L�nea/s del code smell: 24-25, 26-27, 28-29, 30-31 y muchas m�s! (Esta optimizaci�n fue necesaria debido a que exist�a mucho c�digo duplicado, debido a que constantemente se est� cambiando el color de la escritura) 
	* Tipo de code smell: C�digo duplicado
	* Refactorizaci�n realizada: Se implemento un m�todo, el cual recib�a el texto, el color y que por defecto no haga un salto de l�nea 
	"displayMessage"
	* L�neas de refactorizaci�n: Clase ConsoleDisplayer, l�nea 11
## Code smell 8: 
	* Linea/s del code smell: 15, 18
	* Tipo de code smell: Condicional negativo y "Uncommunicative Name"
	* Refactorizaci�n realizada: Se cambio el nombre de la variable a una m�s entendible que adem�s se pueda usar como una condicional positiva en el c�digo
	* L�neas de refactorizaci�n: Clase TextFileManager, l�nea 89 y 98
## Code smell 9: 
	* L�nea/s del code smell: 68-77 y 200-209
	* Tipo de code smell: C�digo duplicado
	* Refactorizaci�n realizada: Se extrajo el c�digo en un m�todo, llamado "displayFileTextContent"
	* L�neas de refactorizaci�n: Clase ConsoleDisplayer, l�nea 37
## Code smell 10: 
	* L�nea/s del code smell: 62-65, 127-130, 162-165 y 194-197 
	* Tipo de code smell: C�digo duplicado
	* Refactorizaci�n realizada: Se extrajo el c�digo en un m�todo, llamado "SelectTextAndExecuteOrder"
	* L�neas de refactorizaci�n: Clase TextFileManager, l�nea 120
## Code smell 11: 
	* L�nea/s del code smell: 64, 129, 164 y 196 
	* Tipo de code smell: "Uncommunicative Name", el nombre "chosenTxt" hace entender que la variable es un String o un objeto, cuando en realidad es un numero entero.
	* Refactorizaci�n realizada:  Se cambio el nombre de la variable
	* L�neas de refactorizaci�n: Clase TextFileManager, l�nea 121

	
