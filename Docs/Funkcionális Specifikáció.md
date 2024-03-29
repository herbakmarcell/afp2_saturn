# Funkcionális specifikáció
## 1. Jelenlegi helyzet leírása

Manapság Magyarországon az egyetemi tanulmányaikat folytató hallgatók csupán egyetlen, elavult rendszert tudnak választani, ha a tanulmányaikhoz tartozó információkat digitálisan szeretnék elérni, például az órarendjüket elérni, vagy tanulmányi átlagaikat megtekinteni, vagy ha az oktatással kapcsolatos ügyeiket szeretnék intézni, például félévet aktiváltatni, vagy tárgyakat felvenni. Ez a rendszer a Neptun, amely egy régi típusú weboldal, mely teljesítmény problémáktól szenved, és átláthatatlan, nem intuitív kezelőfelülettel rendelkezik. rendszeres leállások és az elavult kezelőfelület hátráltatja az egyetemi oktatók és hallgatók munkáját. A jelenlegi rendszer túl sok információval árasztja el a felhasználót első pillantásra, a felületnek egy nagyon hosszadalmas betanulási ideje van, ami miatt a felhasználók a legtöbb időt az alpontokban való kereséssel töltik. Az oldalon használt grafikai elemek teljesen elavultak, a felhasználó ingerei túltelítődnek a különböző színes ikonoktól, képektől és szöveghalmazoktól, az oldal fehér alapszíne pedig elfárasztja a szemet. Ezen problémák alapján sürgető szükség van egy modern, felhasználóbarátabb rendszerrel ellátott alternatívára, amely az oktatási folyamat támogatását helyezi középpontba.

## 2. Vágyálomrendszer leírása

A Neptun rendszer elavult és túlbonyolított, ezért a Kézifék E.Inc. egy saját fejlesztésű asztali alkalmazást kíván létrehozni annak leváltására. Az új alkalmazás célja, hogy felhasználóbarát, modern megjelenésű és reszponzív legyen, valamint nagy segítséget nyújtson minden felhasználónak, szerepkörtől függetlenül. Az elavult régi webes dizájnt egy új, modern, optimalizált rendszerre kívánjuk cserélni a Microsoft .NET keretrendszer igénybevételével. Mivel a kompatibilitás miatt ezzel problémába ütköznénk, az egyéb operációs rendszerek és más digitális eszközökön, legyen az mobiltelefon, tablet stb. ezért egyelőre csak számítógépes felületre készül. A későbbiekben szeretnénk egy webes felületet is létrehozni az alkalmazásnak, hogy minden platformon elérhető legyen. Amellett, hogy az eddig megtalálható funkciókat a Neptunban rendszerében újra dolgozzuk, további opciókat szeretnénk hozzáadni, mellyel hasznosabbá válna, és olyan információk is elérhetőek lennének, amelyek az eredetiből hiányoznak, ezzel is jobbá téve a felhasználói élményt. Továbbá a régi dizájnt eldobni, és új, modern, minimalisztikus stílusra váltani, ezzel is azt sugallva, hogy a rendszerünk naprakész. Bízunk abban, hogy képesek leszünk egy olyan rendszert megalkotni, amelyet a felhasználók szívesen használnak.

## 3. Jelenlegi üzleti folyamatok modellje

A jelenlegi felhasználói felület webes felületen keresztül történő bejelentkezést és egy korlátozott használhatóságú mobilalkalmazást biztosít. A rendszer lassú működése miatt a felhasználói élmény alacsony, és gyakran problémát okoz a felhasználók számára. A menükben való navigálás hosszadalmas és kényelmetlen, mert nem logikus a felépítés, és nehéz megtalálni a keresett funkciókat. Emellett gyakran előfordulnak hibák és összeomlások, amelyek tovább rontják a felhasználói élményt. Az alkalmazás postaládája bár tárolja a bejövő üzeneteket, azonban hiányzik a hatékony kommunikáció lehetősége a felhasználók között. Összességében a jelenlegi rendszer nem elég rugalmas és felhasználóbarát, ami negatívan befolyásolja a felhasználói elégedettséget és hatékonyságot.

## 4. Igényelt üzleti folyamatok modellje

Elkészíteni egy olyan alkalmazást, amelynek funkciói lehetővé teszik az egyetemi polgároknak hogy mindennapi feladataikat elvégezzék egy összefogó felületen.
A dizájn könnyen átlátható és kezelhető, flat, és mindenek előtt megfelelően, a napjainkban átlagos sebességgel működnek a funkciói.
A felület a bejelentkezés során meg tudja különböztetni a jogköröket, így az oktatók és hallgatók kezelőfelülete és funkcióit elválasztva kezeli.
Az elvárások a hallgatói oldalról, a kényelmes tárgy felvétel és leadás, vizsgajelentkezés, a felvett tárgyak, órarendbe szervezve megjelenítve, illetve a felvett tárgyakra kapott érdemjegyeket is meg tudja tekinteni.
Az oktatói jogkörrel rendelkező felhasználó képes vizsgákat kiírni, megtekinthesse az általa tartott vagy felügyelt kurzusokat és a rájuk adott értékeléseket.
Valamint személyes ügyek esetén tudjon kapcsolatot teremteni mindkét fél a másikkal. Az alapvető használati útmutató a kezdő felhasználóknak könnyen elérhető legyen, egy menüpontban ezzel segítve az eligazodást.

A Saturn felépítése, a már ismert Neptun-hoz hasonló lesz a felületben és működésben.
Az alkalmazás a következőket fogja tartalmazza:

-   Felhasználó kezelés
-   Személyes adatok megtekintése
-   Tanulmányi teljesítmény
-   Tárgyfelvétel
-   Tárgy kiírás
-   Vizsgajelentkezés
-   Vizsga kiírás
-   Érdemjegy beírás
-   Órarend
-   Ügyintézés
-   Használati útmutató


## 5. Követelménylista

| ID | Modul | Név | Kifejtés |
| :---: | --- | --- | --- |
| K1  | Felhasználókezelés | Bejelentkezés  | Felhasználó bejelentkeztetése. |
| K2  | Felhasználókezelés | Profilkezelés  | Személyes adatok megtekintése és módosítása |
| K3  | Tanulmányok | Tanulmányi teljesítmény  | Tartalmazza a hallgató álltal felvett kurzusok és félévekre kapott érdemjegyeket. |
| K4  | Tanulmányok | Tárgyfelvétel | A hallgató felhasználó félévente tárgyakat tud felvenni. |
| K5  | Tanulmányok | Tárgy kiírás | Az oktató felhasználó kurzust tud kiírni az általa oktatott tárgyakból. |
| K6  | Tanulmányok | Érdemjegybeírás | Az oktató felhasználó jegyet tud beírni az által oktatott tárgyakból. |
| K7  | Tanulmányok | Órarend | A felhasználó meg tudja tekinteni az óráit. |
| K8  | Vizsgák | Vizsgajelentkezés | A hallgató a már felvett tárgyakból kiírt vizsgákra tud jelentkezni. |
| K9  | Vizsgák | Vizsga kiírás | Az oktató a saját kurzusaiból vizsgaalkalmakat tud kiírni a rendszerbe. |
| K10  | Ügyintézés | Dokumentumok | Egyetemi dokumentumok letöltése. |
| K11  | Ügyintézés | Kérvények | Kitölthető kérvények feltöltése. |
| K12  | Használati útmutató | GYIK | Gyakran ismételt kérdések. |
| K13  | Használati útmutató | Részletes leírás | Az alkalmazás részletes leírása. |

## 6. Használati esetek

### Oktató

 + Egy bővebb de másabb kezelőfelülete van mint a hallgatónak. Tárgyakat tud kiírni és azokra kurzusokat emghírdetni. Értékelni tudja a hallgatók teljesítményét, érdemjegyeket adni nekik a kurzosokra és vizsgákra.

### Hallgató

 + Egy szűkebb hatáskörrel rendelkező felhasználó, de a hallhatónak is vannak egyedi funkciói, mint például a tárgy- és vizsgafelvétel. Meg tudja tekinteni a kapott érdemjegyeket és féléves adatait.

## 7. Megfeleltetés, hogyan fedik le a használati eseteket a követelményeket

| ID | Megfeleltetés | Referencia |
| --- | --- | --- |
| C1 | Felhasználó kezelés | [K1, K2] és kijelentkezés |
| C2 | Tanulmányok | [K3, K4, K5, K6, K7], Megtekinthetők a félévi teljesítmények, tárgyakat lehet kiírni és felvenni, érdemjegyeket adni és órarendet tervezni. |
| C3 | Vizsgák | [K8, K9], Vizsgákat lehet kiírni és azokra jelentkezni. |
| C4 | Ügyintézés | [K10, K11], Az egyetem dokumentumait le lehet tölteni, a kérvényeket ki lehet tölteni. |
| C5 | Használati útmutató | [K12, K13], Megtekinthetők az alkalmazás leírása és a hozzá fűzűdő gyakori kérdések. |

## 8. Képernyőtervek
### Felső Menüsoros Felület - Órarend (Herbák Marcell)
![saturn_felso_soros_orarend](https://github.com/herbakmarcell/afp2_saturn/assets/128597041/780b711d-1340-4556-90fc-116f5cfdeb9e)
### Alkalmazás indítása - Logo (Pántya Barnabás)
![saturnstartupscreen](https://github.com/herbakmarcell/afp2_saturn/assets/135157255/9ad471fe-662f-4cc0-b231-ad2257ef6542)
### Felső Menüsoros Felület - Adatlap (Pántya Barnabás)
![saturnadatlap](https://github.com/herbakmarcell/afp2_saturn/assets/135157255/04a227af-6f93-4a18-9d52-63f78f58e921)
### Felső Menüsoros Felület - Vizsga kiírás (Fodor Győző Benedek)
![vizsgakiiras](https://github.com/herbakmarcell/afp2_saturn/assets/117568964/a3e29c98-aa27-48ce-b3d1-4c6466e69d1b)
### Felső Menüsoros Felület - Kurzus kiírás (Fodor Győző Benedek)
![kurzuskiiras](https://github.com/herbakmarcell/afp2_saturn/assets/117568964/8f9db6e1-1ac9-40a0-b11a-4dba6e9d3417)
### Bejelentkezési felület - Bejelentkezési felület (Détári Levente)
![bejelentkezes_terv](https://github.com/herbakmarcell/afp2_saturn/assets/128597041/bf8b3af2-5e4a-45ea-8cb9-a308a10215b9)


## 9. Forgatókönyvek

Minden felhasználónak elsősorban a főoldal jelenik meg:

 * A belépés gombra kattintva, a belépés menübe kerül a felhasználó ahol az adatait megadva beléphet amennyiben van már regisztrált profilja.
 * A regisztráció gombra kattintva, a regiszrációs menübe kerül a felhasználó ahol az adatait megadva új profilt hozhat létre.

Belépés után visszakerül a felhasználó a főoldalra ahol:

 * Választhat a menüpontok közül

Egy menüpontra kattintva az adott oldalra érkezik a felhasználó:

 * Vizsgát írhat ki vagy vehet fel.
 * Tárgyat írhat ki vagy vehet fel, adhat le.
 * Megtekintheti az órarendjét, érdemjegyeit, kurzusait

Ügyeket intézhet:

 * Írhat üzenetet oktatójának vagy hallgatójának.
 * Letölthet egyetemi dokumentumokat.
 * Kitöltheti a kiküldött egyetemi kérvényeket.

## 10. Funkció - követelmény megfeleltetése

| Id | Követelmény | Funkció |
| :---: | --- | --- |
| I1 | K1 | FK1 |
| I2 | K1 | FK2 |
| I3 | K3 | FK3 |
| I4 | K4 | FK4 |
| I5 | K7 | FK6 |
| I6 | K8 | FK8 |
| I7 | K9 | FK9 |
| I8 | K10 | FK11 |

## 11 Fogalomszótár

-   **Applikáció:** Alkalmazás.
-   **App:** Alkalmazás.
-   **Dizájn:** Egy ipari termék külsejének a tervezete.
-   **Intuitív:** Élményszerű felismerésen alapuló, egyértelmű.
-   **Platform:** Felület. 
-   **Reszponzív:** Kedvezően reagáló.
-   **Flat:** Két dimenzió hatású felület.
