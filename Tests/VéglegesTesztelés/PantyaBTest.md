# Végleges tesztelés

## **Dátum:** 2024.05.21
 - Tesztelő: **Pántya Barnabás**
 - Manuális (kézi) tesztelés

## Alkalmazás

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Pénzügyek felület | A pénzügye felület kilistázza az adott tárgyakat. | Nem listázza ki a tárgyakat. | Nincs backend. |
| T02 | Pénz hozzáadása | Egyenleg feltöltése a felhasználónak | Nem lehetséges a feltöltés | Nincs backend. |
| T03 | Tárgyak kifizetése | Befizetésre váró tárgyakat ki lehet fizetni | Nem lehetséges kifizetni a tárgyakat. | Nincs backend. |
| T04 | Kifizetett tárgyak | A kifizetett tárgyak státusza megváltozik | A státusz nem változik | Nincs backend. |
| T05 | Tárgyak befizetésének határideje | A tárgyaknak van megadott határideje. | A tárgyak határidejének nincs jelentősége. | Nincs backend. |
| T06 | Tárgyak neve | A tárgyaknak van megadott neve | A tárgyak nem léteznek. | Nincs backend. |

 ## Megjelenés

| # | Teszteset | Várható eredmény | Valós eredmény | Megjegyzés |
|------------|------------|---------------|--------------------|------------|
| T01 | Pénzügyek megjelenítése | Megjelenik a pénzügyek grafikus felülete. | A pénzügyek grafikus felülete hibamentesen megjelenik. | Nincs probléma. |
| T02 | Egyenleg feltöltés megjelenítése | Megjelenik az egyenlegfeltöltő panel| Az egyenlegfeltöltés grafikus felülete hibamentesen megjelenik. | Nincs probléma. |
| T03 | Egyenleg feltöltés visszavonása | A vissza gombra kattintva félbeszakad az egyenlegfeltöltés. | A vissza gombra kattintva bezárul az egyenlegfeltöltő panel, és félbeszakad a feltöltés. | Nincs probléma. |

