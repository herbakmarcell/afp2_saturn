# Alfa tesztelés

## **Dátum:** 2024.04.22
 - Tesztelő: **Fodor Győző Benedek**
 - Manuális (kézi) tesztelés

## Alkalmazás

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezés Hallgató adatokkal | Lejátssza a gifet és megnyílik a főfelület. A jogkörnek megfelelő elemek láthatók | Az eredmény kielégítő. | Nincs hiba. |
| T02 | Bejelentkezés Admin adatokkal | Lejátssza a gifet és megnyílik a főfelület. A jogkönek megfelelő elemek láthatók | Az eredmény kielégítő. | Nincs hiba. |
| T03 | Súgó gombok működése | A súgó gombok megnyitják a hozzájuk tartozó üzenetet és minden funkcióról tájékoztatják a felhasználót. | A megjelenített üzenetek helyesek, de még bővítésre szorulnak. | Bővítésre vár. |
| T04 | Kilépés gombok működése | A kilépés gombok bezárják a hozzájuk tartozó oldalt. | Az eredmény kielégítő. | Nincs hiba. |
| T05 | Navigátor gombok működése | A navigátor gombok jól működnek, a megfelelő cél-oldalra vezetnek. | Az eredmény kielégítő. | Nincs hiba. |
| T06 | Regisztráció gomb funkciói | A regisztráció csak Admin jogkörrel rendelkező felhasználónak jelenik meg. A megfelelő céloldalra vezet. | Az eredmény kielégítő. | Nincs hiba. |
| T07 | Felhasználó kezelés, Módosítás gomb | A módosítás gomb a megfelelő céloldalra vezet. Jogkörnek megfelelő elemek jelennek meg | Az eredmény kielégítő. | Nincs hiba. |
| T08 | Adat módosítás | A jogkörfüggetlen adatokat, bármelyik jogkörrel sikeresen lehet módosítani. | Az eredmény kielégítő. | Nincs hiba. |
| T09 | Jogkör specifikus adatmódosítás | Az admin jogkörrel végrehajtott adatmódosítás sikeres a kiválasztott saturnkódú felhasználó adatain. | Az eredmény kielégítő. | Nincs hiba. |
| T10 | Adatmódosítás hibás adatokkal | Módosítás során, hibásan megadott adat esetében, megfelelő hibát dob. | Az eredmény kielégítő. | Nincs hiba. |
| T11 | Regisztráció hiányzó adatokkal | A hiányos adatokkal való regisztráció során, megfelelő hibát dob. | A vezetéknév és az utónév hibaüzenete felcserélődött. | Javításra szorul. |
