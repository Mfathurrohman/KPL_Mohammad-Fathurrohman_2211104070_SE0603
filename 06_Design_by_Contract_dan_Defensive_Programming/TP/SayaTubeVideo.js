class SayaTubeVideo {
    constructor(title) {
        if (!title || title.length > 100) {
            throw new Error("Judul video harus diisi dan maksimal 100 karakter.");
        }
        
        this.id = Math.floor(10000 + Math.random() * 90000); // ID 5 digit acak
        this.title = title;
        this.playCount = 0;
    }

    IncreasePlayCount(count) {
        if (count > 10000000) {
            throw new Error("Penambahan play count maksimal 10.000.000 per panggilan.");
        }
        
        try {
            let newPlayCount = this.playCount + count;
            if (newPlayCount > Number.MAX_SAFE_INTEGER) {
                throw new Error("Jumlah play count melebihi batas maksimal integer.");
            }
            this.playCount = newPlayCount;
        } catch (error) {
            console.error("Terjadi kesalahan: ", error.message);
        }
    }

    PrintVideoDetails() {
        console.log(`ID: ${this.id}`);
        console.log(`Judul: ${this.title}`);
        console.log(`Jumlah Tayang: ${this.playCount}`);
    }
}

// Contoh penggunaan
try {
    let video = new SayaTubeVideo("Tutorial Design By Contract – Fathur");
    video.PrintVideoDetails();
    video.IncreasePlayCount(5000000);
    video.PrintVideoDetails();
    video.IncreasePlayCount(15000000); // Akan menghasilkan error
} catch (error) {
    console.error("Error saat membuat video: ", error.message);
}
