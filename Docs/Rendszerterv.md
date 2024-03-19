# Rendszerterv
## 1. A rendszer célja

Alkalmazásunk célja egy modern, digitális egyetemi index létrehozása, amely átfogó megoldást kínál az egyetemi adatok nyilvántartására és kezelésére.
A fő cél az, hogy az alkalmazás lehetővé tegye a hallgatók és az oktatók számára, hogy egyszerűen és hatékonyan nyomon követhessék az oktatási folyamatban és az
egyetemi életben történő eseményeket és tevékenységeket. Alkalmazásunk lehetőséget biztosít a hallgatóknak az adataik, érdemjegyeik, óráik, előadásaik,
vizsgáik és tanulmányi előrehaladásuk pontos rögzítésére és nyomon követésére. Emellett kényelmi funkciókkal gazdagítja az egyetemi adminisztrációt,
lehetőséget adva például az egyszerűbb dokumentumkezelésre, ütemtervek kezelésére. Mindezek mellett könnyen kezelhető és átlátható mind az oktatók, mind
a hallgatók számára, így elősegítve az oktatási folyamat hatékonyságát és az információ áramlását az egyetemi közösségben. A felhasználóbarát
felület és a könnyen kezelhetőség biztosítása kulcsfontosságú, hogy mindenki számára hozzáférhető legyen és hatékonyan tudja használni az alkalmazást. 

## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
  * Scrum master:
	 -   Györkis Tamás 	
  * Product owner:
	-   Györkis Tamás 
  * Üzleti szereplő:
	  -   Megrendelő:
		  -  Birinyi Gergő
     
### 2.2 Projektmunkások és felelőségek:
   * Frontend:
     - Pántya Barnabás
     - Fodor Győző Benedek
     - Herbák Marcell
   * Backend:
     - Herbák Marcell
     - Détári Levente
     - Pántya Barnabás
   * Tesztelés:
     - Détári Levente
     - Fodor Győző Benedek
     - Herbák Marcell
     - Pántya Barnabás
     
### 2.3 Ütemterv:

|Funkció                  | Feladat                             | Prioritás | Becslés (nap) | Aktuális becslés (nap) | Eltelt idő (nap) | Határidő (nap)      |
|-------------------------|-------------------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                              |         1 |             1 |                      1 |                1 |                   1 |             
|Funkcionális specifikáció|Megírás                              |         1 |             1 |                      1 |                1 |                   1 |
|Rendszerterv             |Megírás                              |         1 |             1 |                      1 |                2 |                   2 |
|Front End                |Vizuális tervek elkészítése          |         1 |             1 |                      1 |                1 |                   1 |
|Front End                |Felület prototípus elkészítése       |         2 |             2 |                      2 |                0 |                   2 |
|Front End                |Felület prototípus bővítése          |         3 |             4 |                      3 |                0 |                   4 |
|Back End                 |Alapfunkciók elkészítése             |         3 |             5 |                      3 |                0 |                   5 |
|Front- és Back End       |Összekötött prototípus elkészítése   |         3 |             4 |                      5 |                0 |                   4 |
|Front- és Back End       |Alpha tesztelés                      |         4 |             1 |                      1 |                0 |                   1 |
|Front End                |Felület prototípus bővítése          |         5 |             4 |                      4 |                0 |                   3 |
|Back End                 |Komplex funkciók elkészítése         |         5 |             5 |                      5 |                0 |                   5 |
|Front- és Back End       |Összekötött prototípus bővítése      |         5 |             4 |                      4 |                0 |                   4 |
|Front- és Back End       |Béta tesztelés                       |         6 |             1 |                      1 |                0 |                   1 |
|Front End                |Felület prototípus befejezése        |         7 |             3 |                      3 |                0 |                   3 |
|Back End                 |Komplex funkciók elkészítése         |         7 |             5 |                      5 |                0 |                   5 |
|Front- és Back End       |Végleges prototípus elkészítése      |         7 |             5 |                      5 |                0 |                   5 |
|Front- és Back End       |Végleges tesztelés                   |         8 |             2 |                      2 |                0 |                   2 |

### 2.4 Mérföldkövek:
   
   *   03.06. Követelmény specifikáció elkészítése
   *   03.09. Funkcionális specifikáció elkészítése
   *   03.10. Rendszerterv elkészítése
   *   03.13. Dokumentációk prezentálása
   *   03.27. Kezelőfelület implementálása
   *   04.03. II. Sprint prototípus prezentálása
   *   04.10. Alapvető funkciók implementálása
   *   04.16. Alpha tesztelések
   *   04.17. III. Sprint prototípus prezentálása
   *   04.24. Komplex funkciók implementálása
   *   04.30. Béta tesztelések
   *   05.01. IV. Sprint prototípus prezentálása
   *   05.15. Kényelmi funkciók implementálása
   *   05.20. Végleges tesztelések
   *   05.22. V. Sprint végső prototípus bemutatása

## 3. Üzleti folyamatok modellje

### 3.1 Üzleti szereplők
Az oldal regisztráció után válik használhatóvá, viszont kizárólag magyar felsőoktatásban résztvevő (mint hallgatói mint tanári felhasználók) személyek tudnak az oldalra regiszrálni, és azt a regisztráció után használatba venni. A felhasználók által elért funkciók eltérnek a tanulmányi rendszerben betöltött szerepüktől függően.

### 3.2 Üzleti folyamatok
Az oldal indulását követően a felhasználónak be kell jelentkeznie a funkciók eléréséhez. A felhasználók által elért funkciók eltérnek a tanulmányi rendszerben betöltött szerepüktől függően.
- __Általános folyamatok:__
     - Regisztrálni az oldalra a megfelelő adatok magadásával.
     - Bejelentkezni az oldalra a regisztráció során megadott megfelelő adatokkal.
     - Bejelentkezés után kijelentkezni az oldalról.
     - A felhasználó adatainak megtekintése.
     - A bejelentkezéskor használandó jelszó megváltoztatása.
- __Tanulói folyamatok:__
	- Órarend megtekintése
	- Tárgyak felvétele, tárgyak részleteinek megtekintése.
	- vizsgák megtekintése, felvétele, részletek megtekintése.
	- Ügyek intézése, kérvények beadása, dokumentumok megtekintése és letöltése.
- __Tanári folyamatok:__
	- vizsgaidőpontok kiírása, szerkesztése.

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
 - Hallgató
   - Kurzusokra jelentkezhet, vizsgákat vehet föl és le, megnézheti az órarendjét
 - Oktató
   - Kurzusokat és vizsgákat írhat ki, értkelheti a hallgatók féléves és vizsgateljesítményét

### 5.2 Menühierarchiák
- Profilom
- Vizsgák
- Kurzusok
- Tanulmányok
- Értékelések
- Belépés
- Kijelentkezés
- Tárgyfelvétel
- Órarend

## 6. Fizikai környezet

### Vásárolt szoftverkomponensek, valamint esetleges külső rendszerek
Nincsenek vásárolt szoftverkomponensek.
### Hardver topológia
Olyan számítógép alkalmas, amely Windows 10 vagy 11 operációs rendszerrel rendelkezik.
### Fizikai alrendszerek
Kliens gépek: A követelményeknek megfelelő, Windows 10 vagy 11 operációs rendszerrel rendelkező PC-k.
Szerver (Host) gép: Az adatbázis rendszer és a háttérfolyamatokat ellátó szolgáltatáshoz szükséges összetevők itt találhatóak. A kliens gép ezzel kommunikál.
### Fejlesztő eszközök
 - Visual Studio 2022
 - Visual Studio Code
 - XAMPP (MySQL)

## 8. Architekturális terv

### Webszerver

- Apache webszerver.

### Adatbázis rendszer

- MySQL alapú adatbázis rendszer.

### A program elérése, kezelése

- Szükséges WinForm, ASP.NET és XAMPP, ami az installáció esetén egy szervergép.

## 9. Adatbázis terv

![saturnconnections](https://github.com/herbakmarcell/afp2_saturn/assets/128597041/1113c108-7b05-41c5-8a89-cc6b96088067)


## 10. Implementációs terv

A projektet két részre oszlik: a frontendre és a backendre. A frontend WinForms segítségével készül, míg a backend ASP.NET keretrendszerben.
A program kódjában használt nyelv elsősorban a magyar.
A szerver és az adatbázist összekötő csomag  felelős az adatbázis kezeléséért.
Mind a frontend, mind a backend fejlesztéséhez szükség van a Visual Studio környezet telepítésére és konfigurálására a szükséges eszközökkel és kiegészítőkkel
együtt.

## 11. Tesztterv

A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata,
ellenőrzése a rendszer által megvalósított üzleti szolgáltatások verifikálása.
A teszteléseket a fejlesztői csapat minden tagja elvégzi.
Egy teszt eredményeit a tagok dokumentálják külön fájlokba.

A tesztelés során a szoftver megfelelő működését vizsgáljuk. Amennyiben az elvártnak megfelelő eredményt kapunk, a teszt eset sikeresnek tekinthető, ellenkező esetben a hibát rögzítjük a teszt jegyzőkönyvben. Ezt követően a megtalált hibákat javítjuk a szoftverben, és újbóli tesztelésnek vetjük alá a rendszert.

### Tesztesetek

 | Teszteset | Elvárt eredmény | 
 |-----------|-----------------| 
 | Regisztráció | A felhasználó az adatok megadásával sikeresen regisztrálni tud |
 | Bejelentkezés |  A felhasználó az adatok megadásával sikeresen be tud jelentkezni |
 | Kijelentkezés | A felhasználó fiókja lekapcsolódik az alkalmazásról, adatait nem lehet elérni |
 | Tanulmányok fül elérése | A felhasználó előtt megjelenik a tanulmányi információ, a tárgyak és az órarend fül |
 | tanulmányi információ megtekintése | A felhasználó részletesebb leírást kap a tanulmányáról. |
 | Tárgyak megtekintése | A felhasználó által felvett tárgyak adatai részletesen megjelennek. |
 | órarend megtekintése | A felhasználó órarendje megjelenik részletes informáciükkal. |
 | Vizsgák megtekintése | A felhasználó ki tudja választani, hogy a vizsgafelvételt, vizsgát kiíratni szeretne, esetleg a vizsgáit megnézni jogkörnek megfelelően. |
 | vizsgajelentkezés elvégzése | A felhasználó jelentkezni tud a vizsgára. |
 | vizsgakiírás elvégzése | A felhasználó sikeresen ki tud írni egy új vizsgát az általa oktatott tárgyból, ha rendelkezik a megfelelő jogkörrel. |
 | ügyintézés megtekintése | A felhasználó le tudja tölteni a dokumentumait, be tud adni sikeresen kérvényeket. |

### A tesztelési jegyzőkönyv kitöltésére egy sablon:

**Tesztelő:** Vezetéknév Keresztnév

**Tesztelés dátuma:** Év.Hónap.Nap

Tesztszám | Rövid leírás | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
például. Teszt #01 | Regisztráció | A felhasználó az adatok megadásával sikeresen regisztrálni tud  | A felhasználó sikeresen regisztrált | Nem találtam problémát.
... | ... | ... | ... | ...

## 12. Telepítési terv

**Fizikai telepítési terv**:
 - A felhasználónak szüksége van egy működő számítógépre, amely rendelkezik internet hozzáféréssel.
 - A szoftverünk működéséhez szükség van egy szerverre. A szervernek kapcsolódni kell egy hálózathoz, hogy elérhető legyen.

**Szoftver telepítési terv**:
 - A felhasználónak szüksége van egy Windows 10 vagy 11 operációs rendszerre, amely támogatja a .NET alkalmazásokat.
 - A szoftverünk futtatható Windows szerveren.
 - Szükség van valamilyen adatbázis szerverre, például MySQL:
   - Szükséges telepíteni az XAMPP nevű szoftvert.
   - Az adatbázis konfigurálása az XAMPP segítségével történik.
 - A backend és frontend konfigurálásához szükség van a Visual Studio integrált fejlesztői környezetre.
   -  Szükséges csomagok a .NET és ASP.NET.
 - A fejlesztők számára az alkalmazás szabadon konfigurálható, fejleszthető.
 - Abban az esetben, ha a szükséges beállítások megtörténtek, a felhasználók számára az alkalmazás futtatható.
   

## 13. Karbantartási terv

Fontos ellenőrizni:
*	Az oldal megfelelően kezeli a kritikus információkat, azok nem elérhetők a megfelelő jogkör és felhasználói adatok nélkül. Ilyenek például a bejelentkezési adatok, és a felhasználók személyes adatai adatai.

Figyelembe kell venni a felhasználó által jött visszajelzést is a programmal kapcsolatban.
Ha hibát talált, mielőbb orvosolni kell, lehet az:
*	Működéssel kapcsolatos
*	Kinézet, dizájnnal kapcsolatos
