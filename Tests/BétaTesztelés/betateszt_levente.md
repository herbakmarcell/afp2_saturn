# Béta tesztelés

## **Dátum:** 2024.05.08
 - Tesztelő: **Détári Levente**
 - Manuális  tesztelés

Alfa tesztelési hibák újraelemzése

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezés próba az alkalmazásba adatok nélkül | Értesíti a felhasználót az szükséges hiányzó adatokról.      | Kivétel kezelve van, de nem jelenik meg a hiba oka. | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/127) |
| T02 | Adatok módosítása nem megfelelő adatokkal         | A felhasználó visszakapja, mely mezők hibásak.               | Felület megvan, azonban hibás a hibaüzenet és annak kezelése | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/169) |
| T03 | Adatok módosítása megfelelő adatokkal             | A felhasználó adatai módosulnak, és értesíti a felhasználót. | Várható eredmény lett. | Nincs. |
| T04 | Mások adatának módosítása Admin jogkör nélkül     | A felhasználót értesíti, hogy nincs jogosultsága erre.       | Frontend-en lehetőség letiltva és várható eredmény lett. | Nincs. |
| T05 | Mások adatának módosítása Admin jogkörrel         | A megadott Saturn kódú felhasználó adatai módosulnak, és a szerkesztő felhasználót értesíti a változásról. | Kivétel kezelve van, de nem jelenik meg a hiba oka. | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/169) |
| T06 | Vizsgára való jelentkezés backendben helyes adatokkal| A megadott adatokkal lefut sikeresen, hozzáadja a users és exams megfelelő listáiba.  | Várható eredmény. | Nincs.|
| T07 | Vizsgára való jelentkezés backendben nem létező felhasználóval| A megadott adatokkal lefut sikeresen, viszont a default felhasználóhoz adja hozzá  | hibakezelés hibája miatt default user kapja meg a vizsgát| Javitandó|
| T08 | Vizsgára való jelentkezés backendben nem létező vizsgával| A megadott adatokkal lefut sikeresen, viszont a default examhoz adja hozzá  | hibakezelés hibája miatt default exam kapja meg a vizsgát | Javitandó|

## Alkalmazás
| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T06 | Bejövő üzenetek fogadása | Megjelennek a felhasználó üzenetei. | Címzettek nem jelennek meg. | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/172) |
| T07 | Kimenő üzenetek fogadása | Megjelennek a felhasználó üzenetei. | Várható eredmény lett. | Nincs. |
| T08 | Üzenetek küldése megfelelő adatokkal | Az üzenetet megkapják a címzettek, és a felhasználót értesíti | Várható eredmény lett. | Nincs. |
| T09 | Üzenetek küldése nem megfelelő adatokkal | A felhasználó visszajelzést kap a hiba okáról. | Várható eredmény lett. | [Formális javítást igényel](https://github.com/herbakmarcell/afp2_saturn/issues/173) |
