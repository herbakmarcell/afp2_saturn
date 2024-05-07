# Béta tesztelés

## **Dátum:** 2024.05.07
 - Tesztelő: **Fodor Győző Benedek**
 - Manuális (kézi) tesztelés

## Alkalmazás

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Navigációs gomb aktív állapot | A navigációs gomok extra színnel jelzik a felhasználónak, hogy aktívak | A navigációs gombok kattintásra világítanak | Nincs hiba. |
| T02 | Postaládára gombra kattintás | Betölti a felületet és az aktív felhasználó beérkezett üzeneteit.| A felület és az üzenetek megjelennek | Nincs hiba. |
| T03 | A vizsgák módosító felülete | A vizsgák módosító felületén adminként lehet hozzáadni és módosítasni a kiválasztott vizsgát. | A felület megjelenik, de csak a vizuális funkciók működnek. | Implementálni kell a vizsgakezelés adatbázis funkcióit. |
| T04 | Üzenetek küldése | Az aktív felhasználó tud üzenetet küldeni más felhasználóknak | A felhasználó elküldte az üzenetet. | Nincs hiba. |
| T05 | Üzenetek fogadása | A felhasználó fogadja az üzeneteket amiket küldtek neki. | A felhasználó megkapja és látja a beérkezett üzeneteket. | Nincs hiba. |
| T06 | Üzenetek küldése több felhasználónak | Egy felhasználó képes több felhasználónak is üzenetet küldeni. Vesszővel elválasztva a címzetteket. | A felhasználó el tudja küldeni az üzenetet több felhasználónak a helyes formátummal. | Nincs hiba. |
| T06 | Üzenetek fogadás több címzett esetén | Az összes címzuett megkapja a nekik küldött üzenetet. | A címzettek megkapják az üzeneteket. | Nincs hiba. |

 ## Megjelenés

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | A vizsgák felületének megjelenítése | A vizsgák felülete megjelenik | A vizsgák felülete megjelenik, viszont adatok nélkül. | Implementálni kell a vizsgakezelés adatbázis funkcióit. |
| T02 | A vizsgák felületének jogkörre szűkített megjelenése | A vizsgák felületén csak a jogkörre vonatkozó funkciók jelennek meg. | Nincs hiba. |
