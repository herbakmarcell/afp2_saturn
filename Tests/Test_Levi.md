# Alfa tesztelés

## **Dátum:** 2024.04.23
 - Tesztelő: **Détári Levente**
 - Manuális (kézi) tesztelés

## Alkalmazás

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezés Hallgató adatokkal | Az oldal a gif lejátszása után sikeren megnyílik, a jogkörnek megfelelő felület jelenik meg | Az eredmény kielégítő. | Nincs hiba. |
| T02 | Bejelentkezés Admin adatokkal | Az oldal a gif lejátszása után sikeren megnyílik, a jogkörnek megfelelő felület jelenik meg | Az eredmény kielégítő. | Nincs hiba. |
| T03 | Súgó gombok működése | A súgó gombokkal megjeleníthetők a hozzájuk rendelt szövegek | A megjelenített üzenetek helyesek, de még bővítésre szorulnak. | Bővítésre vár. |
| T04 | Kilépés gombok működése | A kilépés gombok bezárják a hozzájuk rendelt oldalakat | Az eredmény kielégítő. | Nincs hiba. |
| T05 | Navigátor gombok működése | A navigátor gombok a megfelelő oldalra vezetnek. | Az eredmény kielégítő. | Nincs hiba. |
| T06 | Regisztráció gomb funkciói | A regisztráció csak Admin jogkörrel rendelkező felhasználónak jelenik meg. A megfelelő céloldalra vezet. | Az eredmény kielégítő. | Nincs hiba. |
| T07 | Felhasználó kezelés, Módosítás gomb | A gomb a megfelelő oldalra vezet. Jogkörnek megfelelő elemek jelennek meg | Az eredmény kielégítő. | Nincs hiba. |
| T08 | Adat módosítás | Bármelyik jogkörrel sikeresen lehet módosítani, azokat az adatokat, amik jogkör-függetlenek | Az eredmény kielégítő. | Nincs hiba. |
| T09 | Jogkör specifikus adatmódosítás | Az admin jogkörrel sikeresen végrehajtható a jogkör specifikus adatmódositás. | Az eredmény kielégítő. | Nincs hiba. |
| T10 | Adatmódosítás hibás adatokkal | A módosítás során hibásan megadott adat esetén megfelelő hibát dob. | Az eredmény kielégítő. | Nincs hiba. |
| T11 | Regisztráció hiányzó adatokkal | Hiányos adatokkal való regisztráció során megfelelő hibát dob. | A vezetéknév és az utónév hibaüzenete felcserélődött. | Javításra szorul. |
