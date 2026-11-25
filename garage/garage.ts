interface Verkaufbar {
    readonly Name: string;
}

class Fahrzeug implements Verkaufbar {
    private fahrzeugtyp: string;
    private name: string;

    get Fahrzeugtyp(): string {
        return this.fahrzeugtyp;
    }

    get Name(): string {
        return this.name;
    }

    constructor(fahrzeugtyp: string, name: string) {
        this.fahrzeugtyp = fahrzeugtyp;
        this.name = name;
    }
}

class Fahrrad extends Fahrzeug {
    private anzahlGaenge: number;

    get AnzahlGaenge(): number {
        return this.anzahlGaenge;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlGaenge: number) {
        super(fahrzeugtyp, name);
        this.anzahlGaenge = anzahlGaenge;
    }
}

class Auto extends Fahrzeug {
    private anzahlTueren: number;

    get AnzahlTueren(): number {
        return this.anzahlTueren;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlTueren: number) {
        super(fahrzeugtyp, name);
        this.anzahlTueren = anzahlTueren;
    }
}

class PKW extends Auto {
    private motorTyp: string;

    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("PKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

class LKW extends Auto {
    private motorTyp: string;

    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("LKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

class Garage {
    private verkaufbareDinge: Verkaufbar[] = [];

    public addFahrzeug(fahrzeug: Fahrzeug): void {
        this.verkaufbareDinge.push(fahrzeug);
    }

    public getFahrzeuge(): Fahrzeug[] {
        return this.verkaufbareDinge.filter(
            item => item instanceof Fahrzeug
        );
    }

    public anzahlFahrzeuge(): number {
        return this.verkaufbareDinge.filter(
            item => item instanceof Fahrzeug
        ).length;
    }

    get anzahlAutos(): number {
        return this.verkaufbareDinge.filter(
            item => item instanceof Auto
        ).length;
    }
}

var myBMWWith4Doors = new PKW("BMW", 4, "Benzin");
console.log(myBMWWith4Doors.Fahrzeugtyp);
console.log(myBMWWith4Doors.AnzahlTueren);

var myBMWWith2Doors = new PKW("BMW", 2, "Benzin");
console.log(myBMWWith2Doors.Fahrzeugtyp);
console.log(myBMWWith2Doors.AnzahlTueren);

var myMANWith2Doors = new LKW("MAN", 2, "Diesel");
console.log(myMANWith2Doors.Fahrzeugtyp);
console.log(myMANWith2Doors.AnzahlTueren);

var myFahrrad = new Fahrrad("Fahrrad", "Mountainbike", 21);
console.log(myFahrrad.Fahrzeugtyp);
console.log(myFahrrad.AnzahlGaenge);

var myGarage = new Garage();

myGarage.addFahrzeug(myBMWWith4Doors);
myGarage.addFahrzeug(myBMWWith2Doors);
myGarage.addFahrzeug(myMANWith2Doors);
myGarage.addFahrzeug(myFahrrad);

console.log(`Anzahl Fahrzeuge in der Garage: ${myGarage.anzahlFahrzeuge()} davon Autos: ${myGarage.anzahlAutos}`);