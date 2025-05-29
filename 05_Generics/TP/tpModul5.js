// 4. MENAMBAHKAN METHOD DENGAN GENERIC
class HaloGeneric {
    static SapaUser(user) {
        console.log(`Halo user ${user}`);
    }
}

HaloGeneric.SapaUser("Fathur");

// 6. MENAMBAHKAN CLASS DENGAN GENERIC
class DataGeneric {
    constructor(data) {
        this.data = data;
    }

    PrintData() {
        console.log(`Data yang tersimpan adalah: ${this.data}`);
    }
}

const data = new DataGeneric("2211104070"); 
data.PrintData();