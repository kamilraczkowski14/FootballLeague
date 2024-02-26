Aplikacja została zbudowana zgodnie z Clean Architecture. Zostały stworzone 4 projekty reprezentujące 4 moduły architektury:
- FootballLeague.Domain: zawierający logikę biznesową
- FootballLeague.Application: obsługuje zapytania 
- FootballLeague: moduł prezentacji 
- FootballLeague.Infrastructure: odpowiada za konfigurację bazy danych, łączenie z bazą danych, łączenie z zewnętrznymi usługami.
Dzięki Clean Architekture łatwiejsze jest tesowanie aplikacji, zarządzanie nią, elastyczność w modyfikacjach aplikacji według zasad solid


Zostały stworzone encje:
Season - reprezentująca sezony. Baza danych została zasilona jednym sezonem 2022/2023
League - reprezentująca ligi. Baza danych została zasilona jedną ligą belgijską i została przypisana do sezonu 2022/2023
Team - reprezentująca drużyny. Baza danych została zasilona 18 drużynami i zostały przypisane do ligi belgijskiej
Matchday - reprezentująca kolejki ligowe. Baza danych została zasilona 2 kolejkami które zostały przypisane do ligi belgijskiej
Match - reprezentująca mecze. Baza danych została zasilona 18 meczami i zostały przypisane odpowiednio do odpowiedniej kolejki. Każdy mecz został przypisany do dwóch drużyn.
Baza danych została zasilona danymi w klasie DbSeeder.


Autoryzacja i uwierzytelnianie użytkowników zostały stworzone za pomocą biblioteki ASP.NET Identity. Jednak została stworzona encja User dziedzicząca po UserIdentity w celu rozszerzenia właściwości posiadanych przez użytkownika, a konkretnie meczów.


Zostały stworzone 3 kontrolery:
- Kontroler Account odpowiada za prostą autentykację i akcje rejestracji i logowania oraz zwracanie modeli do widoków.
- Kontroler League z jedną akcją Get odpowiada za zwrócenie ligi belgijskiej
- Kontroler Team odpowiada za wszystkie operacje dotyczące drużyn - dodanie do ulubionych, usunięcie, zwrócenie jednej drużyny na podstawie jej identyfikatora.


W celu operowania na uproszczonych modelach, zostały stworzone modele Dto - LeagueDto i TeamDto.
Do mapowania obiektów z typów League i Team na LeagueDto i TeamDto została użyta biblioteka AutoMapper.
Ta biblioteka usprawnia proces transferu właściwości obiektów z jednego typu na drugi.

Każdy użytkownik może przeglądać tabele, klikając na daną drużynę wyświetla jej 2 mecze.
Zalogowany użytkownik może dodać dany zespół do ulubionych, wejść w dodatkowy widok z ulubionymi meczami, usunąć drużynę z ulubionych.
Jako, że w aplikacji jest jeden zespół i jedna liga - panel filtrujący z opcjami do wybory na stronie Index.cshtml jest sztywno zakodowany na jedną ligę i jeden sezon. Jest to demonstracja filtrowania, jakby to wyglądało w przypadku bardziej rozszerzonej aplikacji o inne ligi i sezony


Możliwości dalszego rozwoju aplikacji:
Dla wszystkich użytkowników - rozszerzenie aplikacji o inne sezony, ligi, zespoły, oprócz samej historii meczów dodać liste najbliższych rozgrywane meczów przez dany zespół i ich daty rozgrywania, tabela mogłaby przyjąć dodatkowe filtry - na przykład ilość zdobytych punktów drużyn na przestrzeni jakiegoś określonego czasu podanego przez użytkownika
Dla zalogowanych użytkowników - możliwość interakcji z innymi użytkownikami, po dodaniu zespołu do ulubionych, możliwość dołączenia do kanału czatowego danego zespołu i tam możliwość korespondencji z fanami o meczach ulubionejk drużyny. Każdy użytkownik mógłby dodawać prywatne i publiczne kanały, dołączać do innych prywatnych kanałów lub publicznych.

