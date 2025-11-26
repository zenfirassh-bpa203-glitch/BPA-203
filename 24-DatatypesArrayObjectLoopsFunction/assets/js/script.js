// 1. Tekrarlanan reqemleri silmek ve tekrar reqemlerin sayini gostermek
function tekrarSay(arr) {
  const sayac = {};
  const tekrarsiz = [];
  
  // Her elementi say
  arr.forEach(element => {
    sayac[element] = (sayac[element] || 0) + 1;
  });
  
  // Tekrarsiz array yarat
  arr.forEach(element => {
    if (!tekrarsiz.includes(element)) {
      tekrarsiz.push(element);
    }
  });
  
  console.log("Orijinal array:", arr);
  console.log("Tekrarsiz array:", tekrarsiz);
  console.log("Tekrar sayilari:", sayac);
  
  return { tekrarsiz, sayac };
}

// Test 1
console.log("=== Task 1 ===");
tekrarSay([1, 2, 3, 2, 4, 1, 5, 3, 3]);


// 2. Verilmis sozun polindrom olub olmadığını yoxlayan alqoritm
function polindromYoxla(soz) {
  // Boyuk/kicik herfleri eyni et ve bosluqlari sil
  const temiz = soz.toLowerCase().replace(/\s/g, '');
  const ters = temiz.split('').reverse().join('');
  
  const netice = temiz === ters;
  console.log(`"${soz}" ${netice ? 'polindroomdur' : 'polindrom deyil'}`);
  
  return netice;
}

// Test 2
console.log("\n=== Task 2 ===");
polindromYoxla("ana");
polindromYoxla("salam");
polindromYoxla("kayak");


// 3. Girilen ededin verilmis arreyde nece elementden kicik oldugunu yazan alqoritm
function kicikSay(eded, arr) {
  let say = 0;
  
  arr.forEach(element => {
    if (eded < element) {
      say++;
    }
  });
  
  console.log(`${eded} arraydə ${say} elementdən kiçikdir`);
  return say;
}

// Test 3
console.log("\n=== Task 3 ===");
kicikSay(5, [1, 3, 7, 9, 2, 10, 4]);


// 4. Daxil edilen ededin Abundant ve ya Deficient oldugunu yoxlayan algorithm
function abundantYoxla(eded) {
  if (eded <= 0) {
    console.log("Müsbət tam ədəd daxil edin");
    return null;
  }
  
  let bolenlerCemi = 0;
  
  // Ozunden basqa butun bolenlerini tap
  for (let i = 1; i < eded; i++) {
    if (eded % i === 0) {
      bolenlerCemi += i;
    }
  }
  
  let netice;
  if (bolenlerCemi > eded) {
    netice = "Abundant";
  } else if (bolenlerCemi < eded) {
    netice = "Deficient";
  } else {
    netice = "Perfect";
  }
  
  console.log(`${eded}: Bölənlər cəmi = ${bolenlerCemi}, Nəticə: ${netice}`);
  return netice;
}

// Test 4
console.log("\n=== Task 4 ===");
abundantYoxla(12);
abundantYoxla(13);
abundantYoxla(6);


// 5. Array-in bütün elementlərini kvadrata yüksəldib yeni array qaytaran funksiya
function kvadrataYukselt(arr) {
  const yeniArray = arr.map(element => element ** 2);
  
  console.log("Orijinal array:", arr);
  console.log("Kvadratlar:", yeniArray);
  
  return yeniArray;
}

// Test 5
console.log("\n=== Task 5 ===");
kvadrataYukselt([1, 2, 3, 4, 5]);