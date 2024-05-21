# Végleges tesztelés

## **Dátum:** 2024.05.21.
 - Tesztelő: **Herbák Marcell**
 - Manuális (kézi) tesztelés

Béta tesztelési hibák újraelemzése

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezés próba az alkalmazásba adatok nélkül | Értesíti a felhasználót az szükséges hiányzó adatokról.      | Kivétel kezelve van, de nem jelenik meg a hiba oka. | Javítandó |
| T02 | Adatok módosítása nem megfelelő adatokkal         | A felhasználó visszakapja, mely mezők hibásak.               | Felület megvan, azonban hibás a hibaüzenet és annak kezelése | Javítandó |
| T03 | Mások adatának módosítása Admin jogkörrel         | A megadott Saturn kódú felhasználó adatai módosulnak, és a szerkesztő felhasználót értesíti a változásról. | Kivétel kezelve van, de nem jelenik meg a hiba oka. | Javítandó |

## Alkalmazás
| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T04 | Bejövő üzenetek fogadása | Megjelennek a felhasználó üzenetei. | Címzettek nem jelennek meg. | Javítandó |
| T05 | Üzenetek küldése nem megfelelő adatokkal | A felhasználó visszajelzést kap a hiba okáról. | Várható eredmény lett. | Nincs. |
| T06 | Vizsga hozzáadása megfelelő adatokkal | A felhasználó visszajelzést kap a vizsga felvételével. | Nincs gomb. | Javítandó. |
| T07 | Vizsga hozzáadása nem megfelelő adatokkal | A felhasználó visszajelzést kap a hiba okáról. | Még mindig nincs gomb. | Javítandó. |
| T08 | Vizsga törlése | Csak tanár és admin felhasználó tud vizgsát törölni. | Nincs gomb. | Javítandó. |
| T09 | Pénz feltöltése | A felhasználó tud feltölteni pénzt a gyűjtőszámlára. | Nincs backend. | Pótolandó. |
| T10 | Pénz feltöltése hibás adatokkal | A felhasználó nem tud feltölteni rossz pénzt a gyűjtőszámlára. | Nincs backend. | Pótolandó. |
| T11 | Pénz feltöltése hibás adatokkal | A felhasználó nem tud feltölteni rossz pénzt a gyűjtőszámlára. | Nincs backend. | Pótolandó. |
