class Kuh {
    private _name: string = "";
    private _colour: string = "";
 
    public get Name() {
        let myLocalVar="myLocalVar"; //lokale Variable, die nur innerhalb der Methode sichtbar ist
        return this._name;
    } // öffentliche Eigenschaft, um den Namen abzurufen
    public get Colour() {return this._colour;} // öffentliche Eigenschaft, um die Farbe abzurufen
    public set Colour(value: string) {this._colour = value;} // öffentliche Eigenschaft, um den Namen zu setzen
 
 
    constructor(name: string, colour: string) { // Konstruktur => "konstruiert" einen Studenten
        this._name = name;
        this._colour = colour;
    }
}
 
let myKuh = new Kuh("Kuh1", "weiß"); // erstellt eine Instanz der Kuh-Klasse
let myKuh1 = new Kuh("Kuh2", "schwarz"); // erstellt eine weitere Instanz der Kuh-Klasse
let myKuh2 = myKuh; // erstellt eine Referenz auf die erste Instanz der Kuh-Klasse
console.log (myKuh2 == myKuh);
console.log(myKuh2.Name); // gibt den Namen der ersten Kuh aus
myKuh.Colour = "braun"; //setzt die Farbe der Kuh auf braun
console.log(myKuh2.Colour); //braun da gleiches Objekt
