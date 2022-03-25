# Grafika komputerowa (Computer graphics)
4 projekty stworzone podczas zajęć z grafi komputerowej.
W kądym prjekcie została użyta technologia WinForms .NET ze wstawkami z C++, w celu przyśpieszenia renderowania obrazów. 

## GK1
Aplikacja do rysowania wielokątów. Pozwala na:
* Rysowanie wielokątów
* Edycja wielokątów
* Zapis i odczyt wielokątów do/z pliku
* Przesówanie wielokątów
* Zmienianie kształtu wielkątu
* Nadawanie relacji krawędziom (prostopadłość lub równoległość)

W folderze znajduje się skompilowana wersja aplikacji. 

## GK2
Aplikacja do wykonywania operacji na obrazach. W aplikacji można:
1. Wybrać tło
2. Wybrać sposób odbijania światła za pomocą mapy wektorów normalnych (przykładowe mapy są załączone w projekcie)
3. Wybrania sposobu wypełniania siatki trojkątów służacej do podzielenia na obrazu na obszary renderowania (wolne/dokładne, szybkie, bardzo szybkie) 
3. Zdefiniowanie wielkości siatki renderowania oraz jej rozmieszczenie
4. Zmienić kolor światła i włączyć ruchome światło

W folderze znajduje się skompilowana wersja aplikacji. 

## GK3
Prostra aplikacja do redukcji użytych kolorów na obrazie. Można użycić własnego zdjęcia lub domyślnego, wybrać liczbę kolorów i zapisać efekt.

W folderze znajduje się skompilowana wersja aplikacji.

## GK4
Aplikacja jest pewnego rodzaju silnikiem graficznym prezentujący podstwaowe funkcje popularnych silników graficznych.

Program składa się z następujących części
* PictureBox pokazujący obecnie generowany obraz
* Suwak do zwiększania lub zmniejszania obrazu w PictureBoxie
* Kontrolery po prawej stronie za pomocą których można:
    1.  Wybrać rodzaj kamery: stała, obracająca się, podążająca za ruszającym się obiektem. 
    Ostatnia kamera może być wybrana tylko
    jeśli pewien obiekt się porusza. Jeśli obiekt przestanie się poruszać,
    automatycznie zostaje wybrana kamera stała. Może być wybrana
    tylko jedna kamera jednocześnie.
    2. Wybór sposobu poruszania się obiektu (sześcianu). Do wyboru są
    ruchy wzdłuż trzech osi wahadłowo i/lub obrót wokół własnego
    środka symetrii. Można wybrać więcej niż jedną opcję jednocześnie.
    3. Wybór cieniowania. Do wyboru są cieniowanie standardowe,
    Gourauda i Phonga. Jedna opcja może być wybrana jednocześnie
    4. Checkbox „Rotate Light”, obraca źródłem światła razem z obracającą
    się kamerą tworząc iluzję nie przemieszczania się. Opcję można
    wybrać tylko przy obracającej się kamerze.
    5. Suwaki Ks,Kd,Ka,N regulują odpowiedne zmienne we wzorze Phonga.
    6. Suwak „Sphere Interpolation Level” wyznacza liczbę trójkątów
    użytych do interpolacji sfery. Skala jest wykładnicza.
    7. Przycisk „Pick Static Light Color” pozwala wybrać kolor światła źródeł
    stałych.
    8. Przycisk „Pick Moving Light Color” pozwala wybrać kolor światła
    źródeł poruszających się.
    9. Checkbox „Show Light” pozwala zobaczyć rzut źródeł świateł na
    ekran. Nie uwzględnia wymiaru głębokości.
    10. Przycisk „Pick Background Color” pozwala wybrać kolor tła.

W folderze znajduje się skompilowana wersja aplikacji.