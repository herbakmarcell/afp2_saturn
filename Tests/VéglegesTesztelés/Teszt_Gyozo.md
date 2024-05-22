# Végleges tesztelés

## **Dátum:** 2024.05.21.
 - Tesztelő: **Fodor Győző Benedek**
 - Manuális (kézi) tesztelés

Béta tesztelési hibák újraelemzése

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Bejelentkezés hiányos adatokkal | Az alkalmazás a hibáról értesíti a fehasználót. | Az alkalmazás lekezeli a kivételt, viszint a kiba okát nem jelzi. | Javításra szorul |
| T02 | A vizsgák módosító felülete | A vizsgák módosító felületén adminként lehet hozzáadni és módosítasni a kiválasztott vizsgát. | A felület megjelenik, de csak a vizuális funkciók működnek. | Pótlásra szorul |
| T03 | Más felhasználók adatának módosítása Adminként | A megadott Saturn kódú felhasználó adatai módosulnak, és a szerkesztő felhasználót értesíti a változásról. | A célfelhasználó adatai módosulnak | Nincs probléma |

## Alkalmazás
| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T04 | Üzenetek küldése nem megfelelő adatokkal | A felhasználó visszajelzést kap a hiba okáról. | Várható eredmény lett. | Nincs. |
| T05 | Vizsga hozzáadása Admin jogkörrel | A felhasználót értesíti az alkalmazás a hozzáadott vizsgáról. | A gomb és adatbázis funkció nincs összeköttetésben. | Javításra szorul. |
| T06 | Vizsgára jelentkezés | A felhasználó értesül a felvett vizsgáról | A gomb és adatbázis funkció nincs összeköttetésben. | Javítandó. |
| T07 | Vizsga módosítása | Az admin tudja módosítani a kiírt vizsgákat. | A gomb és adatbázis funkció nincs összeköttetésben. | Javítandó. |
| T08 | Tárgy hozzáadása Admin jogkörrel | A felhasználót értesíti az alkalmazás a hozzáadott tárgyról. | A gomb és adatbázis funkció nincs összeköttetésben. | Javítandó. |
| T09 | Tárgy törlése Admin jogkörrel | A felhasználót értesíti az alkalmazás a törölt tárgyról. | A gomb és adatbázis funkció nincs összeköttetésben. | Javítandó. |
| T10 | Tárgy módosítása Admin jogkörrel | A felhasználót értesíti az alkalmazás a módosított tárgyról. | A gomb és adatbázis funkció nincs összeköttetésben. | Javítandó. |
| T11 | Tárgy felvétele | A felhasználót értesíti az alkalmazás a felvett tárgyról. | A gomb és adatbázis funkció nincs összeköttetésben. | Javítandó. |
