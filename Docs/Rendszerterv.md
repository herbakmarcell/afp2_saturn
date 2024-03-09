# Rendszerterv
## 1. A rendszer célja

## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
   * Scrum masters:
   * Product owner: 
   * Üzleti szereplő:
     
### 2.2 Projektmunkások és felelőségek:
   * Frontend:
   * Backend:
   * Tesztelés:
     
### 2.3 Ütemterv:

|Funkció                  | Feladat                                | Prioritás | Becslés (nap) | Aktuális becslés (nap) | Eltelt idő (nap) | Becsült idő (nap) |
|-------------------------|----------------------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |             
|Funkcionális specifikáció|Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Rendszerterv             |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Program                  |Képernyőtervek elkészítése              |         2 |             1 |                      1 |                1 |                   1 |
|Program                  |Prototípus elkészítése                  |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Alapfunkciók elkészítése                |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Tesztelés                               |         4 |             2 |                      2 |                2 |                   2 |

### 2.4 Mérföldkövek:
   * Prototípus átadása

## 3. Üzleti folyamatok modellje

### 3.1 Üzleti szereplők

### 3.2 Üzleti folyamatok

## 4. Követelmények

### Funkcionális követelmények

| ID | Megnevezés               | Leírás                                                                                                                                                     |
|----|--------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| K1 | Bejelentkezési ablak     | A felhasználónak egyes funkciók elérése előtt azonosítania kell magát, mielőtt elérhetné azokat.                                                           |
| K2 | Kijelentkezés gomb       | Biztonsági okokból ezzel jelentkezhet ki a fiókjából a felhasználó.                                                                                        |
| K3 | Tanulmányok fül          | A felhasználó itt kiválaszthatja, hogy a tanulmányi átlagát, felvett vagy tanított tárgyait vagy órarendjét szeretné látni, jogkörnek megfelelően.         |
| K4 | Tanulmányi infó          | Itt a felhasználó részletesebb leírást kaphat a tanulmányáról.                                                                                             |
| K5 | Tárgyak                  | Itt a felhasználó részletesebb leírást kaphat a felvett tárgyairól.                                                                                        |
| K6 | Órarend                  | Itt a felhasználó részletesebb leírást kaphat az órarendjéről.                                                                                             |
| K7 | Vizsgák fül              | A felhasználó itt kiválaszthatja, hogy a vizsgafelvételt, vizsgát kiíratni szeretne, esetleg a vizsgáit megnézni jogkörnek megfelelően.                    |
| K8 | Vizsgajelentkezés        | Itt tud a felhasználó vizsgára jelentkezni.                                                                                                                |
| K9 | Vizsgakiírás             | Itt tud a felhasználó vizsgát kiírni az általa oktatott tárgyból, ha rendelkezik megfelelő jogkörrel.                                                      |
| K10 | Vizsgák                  | Itt a felhasználó részletesebb leírást kaphat a vizsgáiról, azokról akár lejelentkezni.                                                                    |
| K11| Ügyintézés fül           | A felhasználó itt letöltheti a dokumentumait, illetve kérvényeket adhat be.                                                                                |
 
### Nemfunkcionális követelmények

| ID  | Megnevezés                             | Leírás                                                                                                                                                       |
|-----|----------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------|
| K12 | Használati útmutató                    | A GYIK gyakori kérdésekre válaszol a Saturn-al kapcsolatban, a használati útmutató pedig segíti a kezdő felhasználót a felület és funkciók elsajátításában.  |
| K13 | Átlátható, könnyen kezelhető felület   | A felületek könnyen használhatóak, átláthatóak legyenek, fülekre osztva a funkciókat, intuitívak, illetve ne legyenek zsúfoltak.                             |
| K14 | Modern dizájn                          | A program megjelenése feleljen meg a napjainkban használt "flat" dizájnnak.                                                                                  |


### Támogatott eszközök

 * Bármely Windows 10 vagy Windows 11-el rendelkező eszköz, amely rendelkezik aktív internethozzáféréssel. Például otthoni számítógép, laptop, tablet.

## 5. Funkcionális terv

### 5.1 Rendszerszereplők

### 5.2 Menühierarchiák

## 6. Fizikai környezet

### Vásárolt softwarekomponensek és külső rendszerek

### Hardver topológia

### Fizikai alrendszerek

### Fejlesztő eszközök


## 8. Architekturális terv

### Webszerver

### Adatbázis rendszer

### A program elérése, kezelése

## 9. Adatbázis terv

## 10. Implementációs terv

## 11. Tesztterv

A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata,
ellenőrzése a rendszer által megvalósított üzleti szolgáltatások verifikálása.
A teszteléseket a fejlesztői csapat minden tagja elvégzi.
Egy teszt eredményeit a tagok dokumentálják külön fájlokba.

### Tesztesetek

 | Teszteset | Elvárt eredmény | 
 |-----------|-----------------| 
 | ... | ... |

### A tesztelési jegyzőkönyv kitöltésére egy sablon:

**Tesztelő:** Vezetéknév Keresztnév

**Tesztelés dátuma:** Év.Hónap.Nap

Tesztszám | Rövid leírás | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
például. Teszt #01 | Regisztráció | A felhasználó az adatok megadásával sikeresen regisztrálni tud  | A felhasználó sikeresen regisztrált | Nem találtam problémát.
... | ... | ... | ... | ...

## 12. Telepítési terv

Fizikai telepítési terv: 

Szoftver telepítési terv: 

## 13. Karbantartási terv

Fontos ellenőrizni:
...

Figyelembe kell venni a felhasználó által jött visszajelzést is a programmal kapcsolatban.
Ha hibát talált, mielőbb orvosolni kell, lehet az:
*	Működéssel kapcsolatos
*	Kinézet, dizájnnal kapcsolatos
