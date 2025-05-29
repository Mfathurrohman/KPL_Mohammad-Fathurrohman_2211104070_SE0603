// 1. Membuat class dengan method generic
class Penjumlahan {
    static jumlahTigaAngka(a, b, c) {
        return Number(a) + Number(b) + Number(c);
    }
}

// Contoh penggunaan dengan angka dari NIM (22, 11, 10)
let hasil = Penjumlahan.jumlahTigaAngka(22.0, 11.0, 10.0);
console.log("Hasil Penjumlahan: ", hasil);

// 2. Membuat class Generic untuk database sederhana
class SimpleDataBase {
    constructor() {
        this.storedData = [];
        this.inputDates = [];
    }

    addNewData(data) {
        this.storedData.push(data);
        this.inputDates.push(new Date().toISOString());
    }

    printAllData() {
        this.storedData.forEach((data, index) => {
            console.log(`Data ${index + 1} berisi: ${data}, disimpan pada ${this.inputDates[index]}`);
        });
    }
}

// Contoh penggunaan
let db = new SimpleDataBase();
db.addNewData(22.0);
db.addNewData(11.0);
db.addNewData(10.0);
db.printAllData();
