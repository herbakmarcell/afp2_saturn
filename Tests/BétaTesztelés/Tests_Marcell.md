# Béta tesztelés

## **Dátum:** 2024.05.07
 - Tesztelő: **Herbák Marcell**
 - Manuális (kézi) tesztelés

Alfa tesztelési hibák újraelemzése

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezés próba az alkalmazásba adatok nélkül | Értesíti a felhasználót az szükséges hiányzó adatokról.      | Kivétel kezelve van, de nem jelenik meg a hiba oka. | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/127) |
| T02 | Adatok módosítása nem megfelelő adatokkal         | A felhasználó visszakapja, mely mezők hibásak.               | Felület megvan, azonban hibás a hibaüzenet és annak kezelése | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/169) |
| T03 | Adatok módosítása megfelelő adatokkal             | A felhasználó adatai módosulnak, és értesíti a felhasználót. | Várható eredmény lett. | Nincs. |
| T04 | Mások adatának módosítása Admin jogkör nélkül     | A felhasználót értesíti, hogy nincs jogosultsága erre.       | Frontend-en lehetőség letiltva és várható eredmény lett. | Nincs. |
| T05 | Mások adatának módosítása Admin jogkörrel         | A megadott Saturn kódú felhasználó adatai módosulnak, és a szerkesztő felhasználót értesíti a változásról. | Kivétel kezelve van, de nem jelenik meg a hiba oka. | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/169) |

## Alkalmazás
| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T06 | Bejövő üzenetek fogadása | Megjelennek a felhasználó üzenetei. | Címzettek nem jelennek meg. | [Javítandó](https://github.com/herbakmarcell/afp2_saturn/issues/172) |
| T07 | Kimenő üzenetek fogadása | Megjelennek a felhasználó üzenetei. | Várható eredmény lett. | Nincs. |
| T08 | Üzenetek küldése megfelelő adatokkal | Az üzenetet megkapják a címzettek, és a felhasználót értesíti | Várható eredmény lett. | Nincs. |
| T09 | Üzenetek küldése nem megfelelő adatokkal | A felhasználó visszajelzést kap a hiba okáról. | Várható eredmény lett. | [Formális javítást igényel](https://github.com/herbakmarcell/afp2_saturn/issues/173) |
