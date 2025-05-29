class SayaTubeVideo {
    constructor(title) {
        if (!title || title.length > 200) {
            throw new Error("Judul tidak boleh kosong dan maksimal 200 karakter");
        }
        this.id = Math.floor(Math.random() * 90000) + 10000; // ID acak 5 digit
        this.title = title;
        this.playCount = 0;
    }

    increasePlayCount(count) {
        if (count <= 0 || count > 25000000) {
            throw new Error("Play count harus antara 1 - 25.000.000");
        }
        if (this.playCount + count > Number.MAX_SAFE_INTEGER) {
            throw new Error("Play count melebihi batas maksimum");
        }
        this.playCount += count;
    }

    printVideoDetails() {
        console.log(`Video ID: ${this.id}`);
        console.log(`Title: ${this.title}`);
        console.log(`Play Count: ${this.playCount}`);
    }
}

class SayaTubeUser {
    constructor(username) {
        if (!username || username.length > 100) {
            throw new Error("Username tidak boleh kosong dan maksimal 100 karakter");
        }
        this.id = Math.floor(Math.random() * 90000) + 10000; // ID acak 5 digit
        this.username = username;
        this.uploadedVideos = [];
    }

    addVideo(video) {
        if (!(video instanceof SayaTubeVideo)) {
            throw new Error("Harus berupa instance dari SayaTubeVideo");
        }
        this.uploadedVideos.push(video);
    }

    getTotalVideoPlayCount() {
        return this.uploadedVideos.reduce((total, video) => total + video.playCount, 0);
    }

    printAllVideoPlaycount() {
        console.log(`User: ${this.username}`);
        this.uploadedVideos.slice(0, 8).forEach((video, index) => {
            console.log(`Video ${index + 1} Judul: ${video.title}`);
        });
    }
}


// Membuat user
const user = new SayaTubeUser("Mohammad Fathurrohman");

// Membuat video
const video1 = new SayaTubeVideo("Review Film 1 oleh Mohammad Fathurrohman");
const video2 = new SayaTubeVideo("Review Film 2 oleh Mohammad Fathurrohman");
const video3 = new SayaTubeVideo("Review Film 3 oleh Mohammad Fathurrohman");
const video4 = new SayaTubeVideo("Review Film 4 oleh Mohammad Fathurrohman");
const video5 = new SayaTubeVideo("Review Film 5 oleh Mohammad Fathurrohman");
const video6 = new SayaTubeVideo("Review Film 6 oleh Mohammad Fathurrohman");
const video7 = new SayaTubeVideo("Review Film 7 oleh Mohammad Fathurrohman");
const video8 = new SayaTubeVideo("Review Film 8 oleh Mohammad Fathurrohman");
const video9 = new SayaTubeVideo("Review Film 9 oleh Mohammad Fathurrohman");
const video10 = new SayaTubeVideo("Review Film 10 oleh Mohammad Fathurrohman");


// Menambahkan video ke user
user.addVideo(video1);
user.addVideo(video2);
user.addVideo(video3);
user.addVideo(video4);
user.addVideo(video5);
user.addVideo(video6);
user.addVideo(video7);
user.addVideo(video8);
user.addVideo(video9);
user.addVideo(video10);

// Menambah play count (valid)
video1.increasePlayCount(1000000);
video2.increasePlayCount(5000000);

// Menampilkan semua video
video1.printVideoDetails();
video2.printVideoDetails();

// Mencetak semua video yang dimiliki user
user.printAllVideoPlaycount();

// Uji coba error handling
try {
    video1.increasePlayCount(30000000); // Harus error karena melebihi 25.000.000
} catch (error) {
    console.error("Error:", error.message);
}

try {
    user.addVideo("Bukan objek SayaTubeVideo"); // Harus error
} catch (error) {
    console.error("Error:", error.message);
}
