
class Animal { // Basisklasse für Tiere

    private _name: string;
    private _colour: string;

    public get Name() {
        return this._name;
    } // öffentliche Methode, um den Namen abzurufen

    public get Colour() {
        return this._colour;
    } // öffentliche Methode, um die Farbe abzurufen

    public set Colour(value: string) {
        this._colour = value;
    } // öffentliche Methode, um die Farbe zu setzen

    public makeSound() {
        console.log("Animal sound");
    } // öffentliche Methode, um den Sound des Tieres auszugeben

    constructor(name: string, colour: string) { // Konstruktor
        let myLocalVar = "myLocalVar"; // lokale Variable, die nur innerhalb des Konstruktors sichtbar ist

        this._name = name;
        this._colour = colour;
    }
}

class Cow extends Animal { // abgeleitete Klasse von Animal

    public makeSound() {
        console.log("Muuuuh");
    } // überschreibt die Methode makeSound() der Animal-Klasse
}

class Cat extends Animal {}

// Erstellt eine Instanz der Animal-Klasse
let myAnimal = new Animal("Animal1", "brown");

myAnimal.makeSound(); // gibt "Animal sound" aus

// Erstellt eine Instanz der Cow-Klasse
let myCow = new Cow("Cow1", "white");

myCow.makeSound(); // gibt "Muuuuh" aus, weil makeSound() überschrieben wurde

let myCow1 = new Cow("Cow2", "black"); // erstellt eine weitere Instanz der Cow-Klasse
let myCow2 = myCow1; // erstellt eine Referenz auf die erste Instanz der Cow-Klasse
console.log (myCow2 == myCow1);
console.log(myCow2.Name); // gibt den Namen der ersten cow aus
myCow.Colour = "brown"; //setzt die Farbe der cow auf braun
console.log(myCow2.Colour); //braun da gleiches Objekt
