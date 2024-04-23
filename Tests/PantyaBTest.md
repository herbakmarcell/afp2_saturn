# Alfa tesztelés

## **Dátum:** 2024.04.23
 - Tesztelő: **Pántya Barnabás**
 - Manuális (kézi) tesztelés

## Alkalmazás

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezés próba az alkalmazásba adatok nélkül | Értesíti a felhasználót az szükséges hiányzó adatokról. | Kivétel kezelve van, de nem jelenik meg a hiba oka. | Javításra vár. |
| T02 | Bejelentkezés próba hibás adatokkal | A felhasználó értesítést kap arról, hogy ezzel az adatokkal nincsen megfelelő jogosultsága. | Az eredmény megfelel az elvárásoknak. | Nincs probléma. |
| T03 | Bejelentkezés megfelelő adatokkal | Az alkalmazás eddig lezárt része használtható. | Az eredmény megfelel az elvárásoknak. | Nincs probléma. |
| T04 | Regisztráció hibás adatokkal | A felhasználó értesítést kap arról, hogy hibás adatokat adott meg. | Az eredmény megfelel az elvárásoknak. | Nincs probléma. |
| T05 | Regisztráció Admin jogkör nélkül | A felhasználó értesítést kap arról, hogy nincs jogosultsága a műveletre. | Az eredmény megfelel az elvárásoknak. | Nincs probléma. |
| T06 | Regisztráció megfelelő adatokkal és Admin jogkörrel | Regisztráció megtörténik, adatbázisba eltárolódik, és a felhasználó értesítést kap a sikeres regisztációról. | Az eredmény megfelel az elvárásoknak. | Nincs probléma. |
| T06 | Felhasználó saját adatainak megjelenítése | A felhasználó saját adatai megjelennek. | A saturnkód kivételével minden adat megjelenik | Javításra vár. |

 ## Megjelenés

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezési felület | Megjelenik a bejelentkezés grafikus felülete. | A bejelentkezés grafikus felülete hibamentesen megjelenik | Nincs probléma. |
| T02 | Fő program felület | Megjelenik a fő program grafikus felülete. | A fő program grafikus felülete hibamentesen megjelenik | Nincs probléma. |
| T03 | Felhasználói adatok felületének megjelenítése | Megjelenik a felhasználói adatok grafikus felülete. | A felhasználói adatok grafikus felülete hibamentesen megjelenik | Nincs probléma. |

