
# Laboratorio 1: Code Smells y Refactorización
Estudiante: Dussan Alejandro Freire Pozo <br>
En la siguiente lista se representan un conjunto de "code smells" del código seleccionado.
# List of code smells:
## Code smell 1: 
	* Línea/s del code smell: Toda la clase "Program.cs"
	* Tipo de code smell: Clase grande
	* Refactorización realizada: Se extrajeron múltiples clases que representen de manera modular y clara el proyecto
	* Líneas de refactorización: 
		Se generaron las siguientes clases para tener los métodos de manera modular 
		* TextOrderExecutor
		* TextFileManager
		* ConsoleDisplayer
## Code smell 2: 
	* Línea/s del code smell: 49-51, 114-116, 149-151 y 181-183
	* Tipo de code smell: Código duplicado
	* Refactorización realizada: Se extrajo el código en un método, llamado "displayErrorMessage"
	* Líneas de refactorización: Clase ConsoleDisplayer, línea 26
## Code smell 3: 
	* Línea/s del code smell: 54-61, 119-126, 154-161 y 186-193
	* Tipo de code smell: Código duplicado
	* Refactorización realizada: Se extrajo el código en un método, llamado "displayFilesListAndMessage"
	* Líneas de refactorización: Clase ConsoleDisplayer, línea 31
## Code smell 4: 
	* Línea/s del code smell: Método "Main" en "Program.cs"
	* Tipo de code smell: Método grande
	* Refactorización realizada: Se extrajeron múltiples métodos y se los distribuyo en diferentes clases
	* Líneas de refactorización: 
		* Refactorización de acciones dentro de cada opción del switch:
			* Clase TextOrderExecutor, líneas 11, 24, 38, 48, 56
		* Refactorización del menú: 
			* Clase TextFileManager, líneas 43, 55 y 87
## Code smell 5: 
	* Linea/s del code smell: 204 
	* Tipo de code smell: "Uncommunicative Name" (Referencia: https://apiumhub.com/tech-blog-barcelona/code-smells/ )
	* Refactorización realizada: Se cambio el nombre de la variable a una más entendible
	* Líneas de refactorización: Clase ConsoleDisplayer, línea 42
## Code smell 6:
	* Linea/s del code smell: 205
	* Tipo de code smell: Condicional negativo
	* Refactorización realizada: Se creo una función que valide la variable en el loop
	* Líneas de refactorización: Clase ConsoleDisplayer, línea 47 y 50
## Code smell 7:
	* Línea/s del code smell: 24-25, 26-27, 28-29, 30-31 y muchas más! (Esta optimización fue necesaria debido a que existía mucho código duplicado, debido a que constantemente se está cambiando el color de la escritura) 
	* Tipo de code smell: Código duplicado
	* Refactorización realizada: Se implemento un método, el cual recibía el texto, el color y que por defecto no haga un salto de línea 
	"displayMessage"
	* Líneas de refactorización: Clase ConsoleDisplayer, línea 11
## Code smell 8: 
	* Linea/s del code smell: 15, 18
	* Tipo de code smell: Condicional negativo y "Uncommunicative Name"
	* Refactorización realizada: Se cambio el nombre de la variable a una más entendible que además se pueda usar como una condicional positiva en el código
	* Líneas de refactorización: Clase TextFileManager, línea 89 y 98
## Code smell 9: 
	* Línea/s del code smell: 68-77 y 200-209
	* Tipo de code smell: Código duplicado
	* Refactorización realizada: Se extrajo el código en un método, llamado "displayFileTextContent"
	* Líneas de refactorización: Clase ConsoleDisplayer, línea 37
## Code smell 10: 
	* Línea/s del code smell: 62-65, 127-130, 162-165 y 194-197 
	* Tipo de code smell: Código duplicado
	* Refactorización realizada: Se extrajo el código en un método, llamado "SelectTextAndExecuteOrder"
	* Líneas de refactorización: Clase TextFileManager, línea 120
## Code smell 11: 
	* Línea/s del code smell: 64, 129, 164 y 196 
	* Tipo de code smell: "Uncommunicative Name", el nombre "chosenTxt" hace entender que la variable es un String o un objeto, cuando en realidad es un numero entero.
	* Refactorización realizada:  Se cambio el nombre de la variable
	* Líneas de refactorización: Clase TextFileManager, línea 121

	
