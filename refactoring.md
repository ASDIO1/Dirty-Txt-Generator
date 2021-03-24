# List of code smells:
## Code smell 1: 
	* Linea/s del code smell: Toda el Program.cs
	* Tipo de code smell: Clase grande
	* Refactorizacion realizada: Se extrageron multiples metodos y se los distribuyo en diferentes clases 
	* Lineas de refactorizacion: 
		Se generaron las siguientes clases para tener los metodos de manera modular 
		* TextOrderExecutor
		* TextFileManager
		* ConsoleDisplayer
## Code smell 2: 
	* Linea/s del code smell: 49-51, 114-116, 149-151 y 181-183
	* Tipo de code smell: Codigo duplicado
	* Refactorizacion realizada: Se extrajo el codigo en un metodo, llamado "displayErrorMessage"
	* Lineas de refactorizacion: Clase ConsoleDisplayer, linea 26
## Code smell 3: 
	* Linea/s del code smell: 54-61, 119-126, 154-161 y 186-193
	* Tipo de code smell: Codigo duplicado
	* Refactorizacion realizada: Se extrajo el codigo en un metodo, llamado "displayFilesListAndMessage"
	* Lineas de refactorizacion: Clase ConsoleDisplayer, linea 31
## Code smell 4: 
	* Linea/s del code smell: Metodo "Main" en program
	* Tipo de code smell: Metodo grande
	* Refactorizacion realizada: Se extrageron multiples metodos y se los distribuyo en diferentes clases
	* Lineas de refactorizacion: 
		* Refactorizacion de acciones dentro del switch:
			* Clase TextOrderExecutor, lineas 11, 24, 38, 48, 56
		* Refactorizacion del menu: 
			* Clase TextFileManager, lineas 43, 55 y 87
## Code smell 5: 
	* Linea/s del code smell: 204 
	* Tipo de code smell: "Uncommunicative Name" (Referencia: https://apiumhub.com/tech-blog-barcelona/code-smells/ )
	* Refactorizacion realizada: Se cambio el nombre de la varible a una mas entendible
	* Lineas de refactorizacion: Clase ConsoleDisplayer, linea 42
## Code smell 5:
	* Linea/s del code smell: 205
	* Tipo de code smell: Condicional negativo
	* Refactorizacion realizada: Se creo una funcion que valide la variable en el loop
	* Lineas de refactorizacion: Clase ConsoleDisplayer, linea 47 y 50
## Code smell 6:
	* Linea/s del code smell: 24-25, 26-27, 28-29, 30-31 y muchas mas 
	* Tipo de code smell: Codigo duplicado
	* Refactorizacion realizada: Al ver que siempre se cambiaba de color antes de escribir algo, se creo el metodo
	"displayMessage"
	* Lineas de refactorizacion: Clase ConsoleDisplayer, linea 11
## Code smell 7: 
	* Linea/s del code smell: 15, 18
	* Tipo de code smell: Condicional negativo y "Uncommunicative Name"
	* Refactorizacion realizada: Se cambio el nombre de la varible a una mas entendible que ademas se pueda usar como una condicional positiva en el codigo
	* Lineas de refactorizacion: Clase TextFileManager, linea 89 y 98
## Code smell 8: 
	* Linea/s del code smell: 68-77 y 200-209
	* Tipo de code smell: Codigo duplicado
	* Refactorizacion realizada: Se extrajo el codigo en un metodo, llamado "displayFileTextContent"
	* Lineas de refactorizacion: Clase ConsoleDisplayer, linea 37
## Code smell 9: 
	* Linea/s del code smell: 62-65, 127-130, 162-165 y 162-165 
	* Tipo de code smell: Codigo duplicado
	* Refactorizacion realizada: Se extrajo el codigo en un metodo, llamado "SelectTextAndExecuteOrder"
	* Lineas de refactorizacion: Clase TextFileManager, linea 120
## Code smell 10: 
	* Linea/s del code smell: 62-65, 127-130, 162-165 y 162-165 
	* Tipo de code smell: "Uncommunicative Name", el nombre "chosenTxt" hace enteneder que la variable es un string o un objeto, cuando en realidad es un entero.
	* Refactorizacion realizada:  Se cambio el nombre de la variable
	* Lineas de refactorizacion: Clase TextFileManager, linea 121

	