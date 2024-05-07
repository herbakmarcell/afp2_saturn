# Alfa tesztelés

## **Dátum:** 2024.04.22
 - Tesztelő: **Herbák Marcell**
 - Manuális (kézi) tesztelés

## Alkalmazás

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezés próba az alkalmazásba adatok nélkül | Értesíti a felhasználót az szükséges hiányzó adatokról. | Kivétel kezelve van, de nem jelenik meg a hiba oka. | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/127) |
| T02 | Bejelentkezés próba hibás adatokkal | Értesíti a felhasználót, hogy ezzel az adatokkal nincs jogosultsága. | Várható eredmény lett. | Nincs probléma. |
| T03 | Bejelentkezés megfelelő adatokkal | Az alkalmazás eddig lezárt része használtható. | Várható eredmény lett. | Nincs probléma. |
| T04 | Regisztráció hibás adatokkal | Értesíti a felhasználót a hibás hiányzó adatokról. | Várható eredmény lett. | Nincs probléma. |
| T05 | Regisztráció Admin jogkör nélkül | Értesíti a felhasználót, hogy nincs jogosultsága erre. | Várható eredmény lett. | Nincs probléma. |
| T06 | Regisztráció megfelelő adatokkal és Admin jogkörrel | Regisztráció megtörténik, adatbázisba eltárolódik, és a felhasználó értesítést kap a sikeres regisztációról. | Várható eredmény lett. | Nincs probléma. |

## API tesztelés
| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T07 | Védett útvonalak elérése bejelentkezés nélkül | A kérést a szerver visszautasítja. | Várható eredmény lett. | Nincs probléma. |
| T08 | Adatok módosítása nem megfelelő adatokkal | A felhasználó visszakapja, mely mezők hibásak. | Várható eredmény lett. | [Nincs kész a felület.](https://github.com/herbakmarcell/afp2_saturn/issues/82) |
| T09 | Adatok módosítása megfelelő adatokkal | A felhasználó adatai módosulnak, és értesíti a felhasználót. | Várható eredmény lett. | [Nincs kész a felület.](https://github.com/herbakmarcell/afp2_saturn/issues/82) |
| T10 | Mások adatának módosítása Admin jogkör nélkül | A felhasználót értesíti, hogy nincs jogosultsága erre. | Várható eredmény lett. | [Nincs kész a felület.](https://github.com/herbakmarcell/afp2_saturn/issues/82) |
| T11 | Mások adatának módosítása Admin jogkörrel  | A megadott Saturn kódú felhasználó adatai módosulnak, és a szerkesztő felhasználót értesíti a változásról. | Várható eredmény lett. | [Nincs kész a felület.](https://github.com/herbakmarcell/afp2_saturn/issues/82) |
