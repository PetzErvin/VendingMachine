# VendingMachine

Acest cod definesc o clasa VendingMachine care ține o variabilă totalCoins pentru a ține evidența monedelor introduse și o variabilă productPrice pentru a ține evidența prețului produsului. Clasa are două metode publice: InsertCoin și BuyProduct.
Metoda InsertCoin acceptă o valoare în centi și verifică dacă aceasta este una din monedele valide(10, 20, 50, 100). Dacă este validă, se adaugă la totalCoins și se afișează un mesaj "Coin inserted: valoare centi". Dacă nu este validă, se afișează un mesaj "Invalid coin. Only 10, 20, 50 and 100 cents coins are accepted.".
Metoda BuyProduct verifică dacă totalCoins este mai mare sau egal cu productPrice. Dacă da, se afișează un mesaj "Product dispensed. Change: valoare centi", se calculeaza restul si se reseteaza totalCoins la 0. Dacă nu, se afișează un mesaj "Not enough money. Insert more coins.".

În Main, se creează o instanță a clasei VendingMachine și se apelează metoda InsertCoin cu diferite valori, apoi se apelează metoda BuyProduct pentru a cumpăra produsul.
