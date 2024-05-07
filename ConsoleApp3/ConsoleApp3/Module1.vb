Imports System.Media

Module Module1

    Sub Main()
        Dim client_food_choice As Integer
        Dim french_food_number As Integer
        Dim french_food_type As String
        Dim french_food_price As Single
        Dim american_food_number As Integer
        Dim american_food_type As String
        Dim american_food_price As Single
        Dim turkish_food_number As Integer
        Dim turkish_food_type As String
        Dim turkish_food_price As Single
        Dim indian_food_number As Integer
        Dim indian_food_type As String
        Dim indian_food_price As Single
        Dim england_food_number As Integer
        Dim england_food_type As String
        Dim england_food_price As Single
        Dim italian_food_type As String
        Dim italian_food_number As Integer
        Dim italian_food_price As Single
        Dim moroccan_food_type As String
        Dim moroccan_food_price As Single
        Dim other_food_choice_number As Integer
        Dim moroccan_food_number As Integer
        Dim tacos_number As Integer
        Dim tacos_type As String
        Dim tacos_price As Single
        Dim drink_number As Integer
        Dim drink_type As String
        Dim drink_price As Single
        Dim ice_number As Integer
        Dim ice_type As String
        Dim ice_price As Integer
        Dim salad_number As Integer
        Dim salad_type As String
        Dim salad_price As Single
        Dim burger_number As Integer
        Dim pizza_number As Integer
        Dim pizza_type As String
        Dim pizza_price As Single
        Dim burger_price As Single
        Dim burger_type As String
        Dim client_first_name As String
        Dim client_last_name As String
        Dim soundPlayer As New SoundPlayer("C:\Users\_L7AJ_MAHMOUD_\OneDrive\Music\No Copyright Sound Effect _ Free Click Sound-(480p)_[cut_0sec].wav")
        'Dim anotherSoundPlayer As New SoundPlayer("C:\Users\_L7AJ_MAHMOUD_\OneDrive\Music\videoplayback (1).wav")'
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("                               *** WELCOME TO H&M RESTAURANT ***    " & Environment.NewLine & Environment.NewLine)
        Console.WriteLine("                                           < MENU >" & Environment.NewLine)
        Console.WriteLine("                                    1 -->           BURGERS" & Environment.NewLine)
        Console.WriteLine("                                    2 -->           PIZZAS" & Environment.NewLine)
        Console.WriteLine("                                    3 -->           SALADS" & Environment.NewLine)
        Console.WriteLine("                                    4 -->           ICE CREAMS" & Environment.NewLine)
        Console.WriteLine("                                    5 -->           DRINKS" & Environment.NewLine)
        Console.WriteLine("                                    6 -->           TACOS" & Environment.NewLine)
        Console.WriteLine("                                    7 -->           OTHER FOOD" & Environment.NewLine & Environment.NewLine)
        Console.WriteLine("                           < CHOOSE YOUR FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
        Console.Write("                                                ")
        client_food_choice = Console.ReadLine()
        If client_food_choice = 1 Then
            soundPlayer.Play()
            Console.Clear()
            Console.WriteLine("                                       < BURGERS LIST >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                              1 -->                      CHEESE BURGER WITH FRIES AND KETCHUP (2 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              2 -->                      BACON BURGER WITH FRIES AND KETCHUP (3.80 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              3 -->                      MUSHROOM SWISS BURGER WITH FRIES AND KETCHUP (8.50 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              4 -->                      BBQ BURGER WITH FRIES AND KETCHUP (8.50 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              5 -->                      VEGGIR BURGER WITH FRIES AND KETCHUP (10 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              6 -->                      TURKEY BURGER WITH FRIES AND KETCHUP (12.10 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              7 -->                      SALMON BURGER WITH FRIES AND KETCHUP (15 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              8 -->                      SLIDER BURGER WITH FRIES AND KETCHUP (16.30 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              9 -->                      GUACAMOLE BURGER WITH FRIES AND KETCHUP (20 EUROS)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                     < CHOOSE YOUR BURGER NUMBER AND PRESS ENTER >" & Environment.NewLine)
            Console.Write("                                                           ")
            burger_number = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            If burger_number = 1 Then
                soundPlayer.Play()
                burger_type = "CHEESE BURGER WITH FRIES AND KETCHUP"
                burger_price = 2
            End If
            If burger_number = 2 Then
                soundPlayer.Play()
                burger_type = "BACON BURGER WITH FRIES AND KETCHUP"
                burger_price = 3.8
            End If
            If burger_number = 3 Then
                soundPlayer.Play()
                burger_type = "MUSHROOM SWISS BURGER WITH FRIES AND KETCHUP"
                burger_price = 8.5
            End If
            If burger_number = 4 Then
                soundPlayer.Play()
                burger_type = "BBQ BURGER WITH FRIES AND KETCHUP"
                burger_price = 8.5
            End If
            If burger_number = 5 Then
                soundPlayer.Play()
                burger_type = "VEGGIR BURGER WITH FRIES AND KETCHUP"
                burger_price = 10
            End If
            If burger_number = 6 Then
                soundPlayer.Play()
                burger_type = "TURKEY BURGER WITH FRIES AND KETCHUP"
                burger_price = 12.1
            End If
            If burger_number = 7 Then
                soundPlayer.Play()
                burger_type = "SALMON BURGER WITH FRIES AND KETCHUP"
                burger_price = 15
            End If
            If burger_number = 8 Then
                soundPlayer.Play()
                burger_type = "SLIDER BURGER WITH FRIES AND KETCHUP"
                burger_price = 16.3
            End If
            If burger_number = 9 Then
                soundPlayer.Play()
                burger_type = "GUACAMOLE BURGER WITH FRIES AND KETCHUP"
                burger_price = 20
            End If
            Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR BURGER :)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                            ")
            client_first_name = Console.ReadLine()
            soundPlayer.Play()
            Console.WriteLine("" & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                            ")
            client_last_name = Console.ReadLine()
            soundPlayer.Play()
            Console.WriteLine("" & Environment.NewLine)
            Console.Clear()
            Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
            Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
            Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
            Console.WriteLine("                                              >   COMMAND      >  " & burger_type & Environment.NewLine)
            Console.WriteLine("                                              >    PRICE       >  " & burger_price & " EUROS" & Environment.NewLine)
            Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
            Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
            Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
            Console.WriteLine("" & Environment.NewLine)
        End If
        If client_food_choice = 2 Then
            soundPlayer.Play()
            Console.Clear()
            Console.WriteLine("                                       < PIZZAS LIST >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                              1 -->                      PIZZA MARGHERITA WITH FRIES AND KETCHUP (4 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              2 -->                      PIZZA HAWAIIAN WITH FRIES AND KETCHUP (7.50 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              3 -->                      PIZZA VEGETARIAN WITH FRIES AND KETCHUP (9.25 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              4 -->                      PIZZA BBQ CHICKEN WITH FRIES AND KETCHUP (10 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              5 -->                      PIZZA WHITE WITH FRIES AND KETCHUP (10.50 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              6 -->                      PIZZA BUFFALO CHICKEN WITH FRIES AND KETCHUP (16 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              7 -->                      PIZZA SUPREME WITH FRIES AND KETCHUP (17.25 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              8 -->                      PIZZA NEAPOLITAN WITH FRIES AND KETCHUP (11.25 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              9 -->                      PIZZA FOUR CHEESE WITH FRIES AND KETCHUP (19.50 EUROS)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                     < CHOOSE YOUR PIZZA NUMBER AND PRESS ENTER >" & Environment.NewLine)
            Console.Write("                                                           ")
            pizza_number = Console.ReadLine()
            If pizza_number = 1 Then
                soundPlayer.Play()
                pizza_type = "PIZZA MARGHERITA WITH FRIES AND KETCHUP"
                pizza_price = 4
            End If
            If pizza_number = 2 Then
                soundPlayer.Play()
                pizza_type = "PIZZA HAWAIIAN WITH FRIES AND KETCHUP"
                pizza_price = 7.5
            End If
            If pizza_number = 3 Then
                soundPlayer.Play()
                pizza_type = "PIZZA VEGETARIAN WITH FRIES AND KETCHUP"
                pizza_price = 9.25
            End If
            If pizza_number = 4 Then
                soundPlayer.Play()
                pizza_type = "PIZZA BBQ CHICKEN WITH FRIES AND KETCHUP"
                pizza_price = 10
            End If
            If pizza_number = 5 Then
                soundPlayer.Play()
                pizza_type = "PIZZA WHITE WITH FRIES AND KETCHUP"
                pizza_price = 10.5
            End If
            If pizza_number = 6 Then
                soundPlayer.Play()
                pizza_type = "PIZZA BUFFALO CHICKEN WITH FRIES AND KETCHUP"
                pizza_price = 16
            End If
            If pizza_number = 7 Then
                soundPlayer.Play()
                pizza_type = "PIZZA SUPREME WITH FRIES AND KETCHUP"
                pizza_price = 17.25
            End If
            If pizza_number = 8 Then
                soundPlayer.Play()
                pizza_type = "PIZZA NEAPOLITAN WITH FRIES AND KETCHUP"
                pizza_price = 11.25
            End If
            If pizza_number = 9 Then
                soundPlayer.Play()
                pizza_type = "PIZZA FOUR CHEESE WITH FRIES AND KETCHUP"
                pizza_price = 19.5
            End If
            Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR PIZZA :)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_first_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_last_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.Clear()
            Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
            Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
            Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
            Console.WriteLine("                                              >   COMMAND      >  " & pizza_type & Environment.NewLine)
            Console.WriteLine("                                              >    PRICE       >  " & pizza_price & " EUROS" & Environment.NewLine)
            Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
            Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
            Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
            Console.WriteLine("" & Environment.NewLine)
        End If
        If client_food_choice = 3 Then
            soundPlayer.Play()
            Console.Clear()
            Console.WriteLine("                                       < SALADS LIST >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                              1 -->                      GARDEN SALAD WITH FRIES AND KETCHUP (2 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              2 -->                      CAESAR SALAD WITH FRIES AND KETCHUP (3.25 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              3 -->                      GREEK SALAD WITH FRIES AND KETCHUP (2.50 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              4 -->                      COBB SALAD WITH FRIES AND KETCHUP (4.25 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              5 -->                      WALDORF SALAD WITH FRIES AND KETCHUP (5 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              6 -->                      CAPRESE SALAD WITH FRIES AND KETCHUP (5 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              7 -->                      NICOISE SALAD WITH FRIES AND KETCHUP (6 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              8 -->                      ASIAN SLAW SALAD WITH FRIES AND KETCHUP (7.50 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              9 -->                      QUINOA SALAD WITH FRIES AND KETCHUP (1.5 EUROS)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                     < CHOOSE YOUR SALAD NUMBER AND PRESS ENTER >" & Environment.NewLine)
            Console.Write("                                                           ")
            salad_number = Console.ReadLine()
            If salad_number = 1 Then
                soundPlayer.Play()
                salad_type = "GARDEN SALAD"
                salad_price = 2
            End If
            If salad_number = 2 Then
                soundPlayer.Play()
                salad_type = "CAESAR SALAD"
                salad_price = 3.25
            End If
            If salad_number = 3 Then
                soundPlayer.Play()
                salad_type = "GREEK SALAD"
                salad_price = 2.5
            End If
            If salad_number = 4 Then
                soundPlayer.Play()
                salad_type = "COBB SALAD"
                salad_price = 4.25
            End If
            If salad_number = 5 Then
                soundPlayer.Play()
                salad_type = "WALDORF SALAD"
                salad_price = 5
            End If
            If salad_number = 6 Then
                soundPlayer.Play()
                salad_type = "CAPRESE SALAD"
                salad_price = 5
            End If
            If salad_number = 7 Then
                soundPlayer.Play()
                salad_type = "NICOISE SALAD"
                salad_price = 6
            End If
            If salad_number = 8 Then
                soundPlayer.Play()
                salad_type = "ASIAN SLAW SALAD"
                salad_price = 7.5
            End If
            If salad_number = 9 Then
                soundPlayer.Play()
                salad_type = "QUINOA SALAD"
                salad_price = 1.5
            End If
            Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR SALAD :)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_first_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_last_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.Clear()
            Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
            Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
            Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
            Console.WriteLine("                                              >   COMMAND      >  " & salad_type & Environment.NewLine)
            Console.WriteLine("                                              >    PRICE       >  " & salad_price & " EUROS" & Environment.NewLine)
            Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
            Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
            Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
            Console.WriteLine("" & Environment.NewLine)
        End If
        If client_food_choice = 4 Then
            soundPlayer.Play()
            Console.Clear()
            Console.WriteLine("                                       < ICE CREAMS LIST >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                              1 -->                      VANILLA ICE CREAM (2 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              2 -->                      CHOCOLATE ICE CREAM (2 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              3 -->                      STRAWBERRY ICE CREAM (2 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              4 -->                      COOKIES AND CREAM ICE CREAM (3 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              5 -->                      ROCKY ROAD ICE CREAM (4 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              6 -->                      COFFEE ICE CREAM (2 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              7 -->                      NEAPOLITAN ICE CREAM (3 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              8 -->                      PISTACHIO ICE CREAM (2 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              9 -->                      COCONUT ICE CREAM (2 EUROS)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                     < CHOOSE YOUR ICE CREAM NUMBER AND PRESS ENTER >" & Environment.NewLine)
            Console.Write("                                                           ")
            ice_number = Console.ReadLine()
            If ice_number = 1 Then
                soundPlayer.Play()
                ice_type = "VANILLA ICE CREAM"
                ice_price = 2
            End If
            If ice_number = 2 Then
                soundPlayer.Play()
                ice_type = "CHOCOLATE ICE CREAM"
                ice_price = 2
            End If
            If ice_number = 3 Then
                soundPlayer.Play()
                ice_type = "STRAWBERRY ICE CREAM"
                ice_price = 2
            End If
            If ice_number = 4 Then
                soundPlayer.Play()
                ice_type = "COOKIES AND CREAM ICE CREAM"
                ice_price = 3
            End If
            If ice_number = 5 Then
                soundPlayer.Play()
                ice_type = "ROCKY ROAD ICE CREAM"
                ice_price = 4
            End If
            If ice_number = 6 Then
                soundPlayer.Play()
                ice_type = "COFFEE ICE CREAM"
                ice_price = 2
            End If
            If ice_number = 7 Then
                soundPlayer.Play()
                ice_type = "NEAPOLITAN ICE CREAM"
                ice_price = 3
            End If
            If ice_number = 8 Then
                soundPlayer.Play()
                ice_type = "PISTACHIO ICE CREAM"
                ice_price = 2
            End If
            If ice_number = 9 Then
                soundPlayer.Play()
                ice_type = "COCONUT ICE CREAM"
                ice_price = 2
            End If
            Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR ICE CREAM :)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_first_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_last_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.Clear()
            Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
            Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
            Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
            Console.WriteLine("                                              >   COMMAND      >  " & ice_type & Environment.NewLine)
            Console.WriteLine("                                              >    PRICE       >  " & ice_price & " EUROS" & Environment.NewLine)
            Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
            Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
            Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
            Console.WriteLine("" & Environment.NewLine)
        End If
        If client_food_choice = 5 Then
            soundPlayer.Play()
            Console.Clear()
            Console.WriteLine("                                       < DRINKS LIST >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                              1 -->                       COFFEE (1 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              2 -->                       TEA (1 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              3 -->                       WATER (1 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              4 -->                       SODA (2.50 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              5 -->                       SOUP (2 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              6 -->                       COCKTAIL (3 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              7 -->                       JUICE (1 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              8 -->                       MILK (1 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              9 -->                       ENERGY DRINK (5.50 EUROS)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                     < CHOOSE YOUR DRINK NUMBER AND PRESS ENTER >" & Environment.NewLine)
            Console.Write("                                                           ")
            drink_number = Console.ReadLine()
            If drink_number = 1 Then
                soundPlayer.Play()
                drink_type = "COFFEE"
                drink_price = 1
            End If
            If drink_number = 2 Then
                soundPlayer.Play()
                drink_type = "TEA"
                drink_price = 1
            End If
            If drink_number = 3 Then
                soundPlayer.Play()
                drink_type = "WATER"
                drink_price = 1
            End If
            If drink_number = 4 Then
                soundPlayer.Play()
                drink_type = "SODA"
                drink_price = 2.5
            End If
            If drink_number = 5 Then
                soundPlayer.Play()
                drink_type = "SOUP"
                drink_price = 2
            End If
            If drink_number = 6 Then
                soundPlayer.Play()
                drink_type = "COCKTAIL"
                drink_price = 3
            End If
            If drink_number = 7 Then
                soundPlayer.Play()
                drink_type = "JUICE"
                drink_price = 1
            End If
            If drink_number = 8 Then
                soundPlayer.Play()
                drink_type = "MILK"
                drink_price = 1
            End If
            If drink_number = 9 Then
                soundPlayer.Play()
                drink_type = "ENERGY DRINK"
                drink_price = 5.5
            End If
            Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR DRINK :)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_first_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_last_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.Clear()
            Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
            Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
            Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
            Console.WriteLine("                                              >   COMMAND      >  " & drink_type & Environment.NewLine)
            Console.WriteLine("                                              >    PRICE       >  " & drink_price & " EUROS" & Environment.NewLine)
            Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
            Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
            Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
            Console.WriteLine("" & Environment.NewLine)
        End If
        If client_food_choice = 6 Then
            soundPlayer.Play()
            Console.Clear()
            Console.WriteLine("                                       < TACOS LIST >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                              1 -->                      CARNE ASADA TACOS WITH FRIES AND KETCHUP (10.5 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              2 -->                      AL PASTOR TACOS WITH FRIES AND KETCHUP (12 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              3 -->                      CARNITAS TACOS WITH FRIES AND KETCHUP (11 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              4 -->                      FISH TACOS WITH FRIES AND KETCHUP (13.5 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              5 -->                      SHRIMP TACOS WITH FRIES AND KETCHUP (15 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              6 -->                      CHICKEN TINGA TACOS WITH FRIES AND KETCHUP (10 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              7 -->                      BARBACOA TACOS WITH FRIES AND KETCHUP (16 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              8 -->                      VEGETARIAN TACOS WITH FRIES AND KETCHUP (11 EUROS)" & Environment.NewLine)
            Console.WriteLine("                              9 -->                      BIRRIA TACOS WITH FRIES AND KETCHUP (17 EUROS)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                     < CHOOSE YOUR TACOS NUMBER AND PRESS ENTER >" & Environment.NewLine)
            Console.Write("                                                           ")
            tacos_number = Console.ReadLine()
            If tacos_number = 1 Then
                soundPlayer.Play()
                tacos_type = "CARNE ASADA TACOS WITH FRIES AND KETCHUP"
                tacos_price = 10.5
            End If
            If tacos_number = 2 Then
                soundPlayer.Play()
                tacos_type = "AL PASTOR TACOS WITH FRIES AND KETCHUP"
                tacos_price = 12
            End If
            If tacos_number = 3 Then
                soundPlayer.Play()
                tacos_type = "CARNITAS TACOS WITH FRIES AND KETCHUP"
                tacos_price = 11
            End If
            If tacos_number = 4 Then
                soundPlayer.Play()
                tacos_type = "FISH TACOS WITH FRIES AND KETCHUP"
                tacos_price = 13.5
            End If
            If tacos_number = 5 Then
                soundPlayer.Play()
                tacos_type = "SHRIMP TACOS WITH FRIES AND KETCHUP"
                tacos_price = 15
            End If
            If tacos_number = 6 Then
                soundPlayer.Play()
                tacos_type = "CHICKEN TINGA TACOS WITH FRIES AND KETCHUP"
                tacos_price = 10
            End If
            If tacos_number = 7 Then
                soundPlayer.Play()
                tacos_type = "BARBACOA TACOS WITH FRIES AND KETCHUP"
                tacos_price = 16
            End If
            If tacos_number = 8 Then
                soundPlayer.Play()
                tacos_type = "VEGETARIAN TACOS WITH FRIES AND KETCHUP"
                tacos_price = 11
            End If
            If tacos_number = 9 Then
                soundPlayer.Play()
                tacos_type = "BIRRIA TACOS WITH FRIES AND KETCHUP"
                tacos_price = 17
            End If
            Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR TACOS :)" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_first_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
            Console.Write("                                                          ")
            client_last_name = Console.ReadLine()
            Console.WriteLine("" & Environment.NewLine)
            Console.Clear()
            Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
            Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
            Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
            Console.WriteLine("                                              >   COMMAND      >  " & tacos_type & Environment.NewLine)
            Console.WriteLine("                                              >    PRICE       >  " & tacos_price & " EUROS" & Environment.NewLine)
            Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
            Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
            Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
            Console.WriteLine("" & Environment.NewLine)
        End If
        If client_food_choice = 7 Then
            soundPlayer.Play()
            Console.Clear()
            Console.WriteLine("                                           < MENU >" & Environment.NewLine)
            Console.WriteLine("                                    1 -->           MOROCCAN FOODS" & Environment.NewLine)
            Console.WriteLine("                                    2 -->           ITALIAN FOODS" & Environment.NewLine)
            Console.WriteLine("                                    3 -->           ENGLAND FOODS" & Environment.NewLine)
            Console.WriteLine("                                    4 -->           INDIAN FOODS" & Environment.NewLine)
            Console.WriteLine("                                    5 -->           TURKISH FOODS" & Environment.NewLine)
            Console.WriteLine("                                    6 -->           FRENCH FOODS" & Environment.NewLine)
            Console.WriteLine("                                    7 -->           AMERICAN FOODS" & Environment.NewLine & Environment.NewLine)
            Console.WriteLine("                           < CHOOSE YOUR FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
            Console.Write("                                                ")
            other_food_choice_number = Console.ReadLine()
            If other_food_choice_number = 1 Then
                soundPlayer.Play()
                Console.Clear()
                Console.WriteLine("                                       < MOROCCAN FOODS LIST >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                              1 -->                      TAGINE (4 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              2 -->                      COUSCOUS (8 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              3 -->                      PASTILLA (11 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              4 -->                      HARIRA (2.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              5 -->                      MECHOUI (7 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              6 -->                      ZAALOK (1.5 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              7 -->                      REFISSA (9 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              8 -->                      SEFFA MEDFOUNA (10 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              9 -->                      MROUZIA (12.50 EUROS)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                     < CHOOSE YOUR MOROCCAN FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
                Console.Write("                                                           ")
                moroccan_food_number = Console.ReadLine()
                If moroccan_food_number = 1 Then
                    soundPlayer.Play()
                    moroccan_food_type = "TAGINE"
                    moroccan_food_price = 4
                End If
                If moroccan_food_number = 2 Then
                    soundPlayer.Play()
                    moroccan_food_type = "COUSCOUS"
                    moroccan_food_price = 8
                End If
                If moroccan_food_number = 3 Then
                    soundPlayer.Play()
                    moroccan_food_type = "PASTILLA"
                    moroccan_food_price = 11
                End If
                If moroccan_food_number = 4 Then
                    soundPlayer.Play()
                    moroccan_food_type = "HARIRA"
                    moroccan_food_price = 2.5
                End If
                If moroccan_food_number = 5 Then
                    soundPlayer.Play()
                    moroccan_food_type = "MECHOUI"
                    moroccan_food_price = 7
                End If
                If moroccan_food_number = 6 Then
                    soundPlayer.Play()
                    moroccan_food_type = "ZAALOK"
                    moroccan_food_price = 1.5
                End If
                If moroccan_food_number = 7 Then
                    soundPlayer.Play()
                    moroccan_food_type = "REFISSA"
                    moroccan_food_price = 9
                End If
                If moroccan_food_number = 8 Then
                    soundPlayer.Play()
                    moroccan_food_type = "SEFFA MEDFOUNA"
                    moroccan_food_price = 10
                End If
                If moroccan_food_number = 9 Then
                    soundPlayer.Play()
                    moroccan_food_type = "MROUZIA"
                    moroccan_food_price = 12.5
                End If
                Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR MOROCCAN FOOD :)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_first_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_last_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.Clear()
                Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
                Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
                Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
                Console.WriteLine("                                              >   COMMAND      >  " & moroccan_food_type & Environment.NewLine)
                Console.WriteLine("                                              >    PRICE       >  " & moroccan_food_price & " EUROS" & Environment.NewLine)
                Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
                Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
                Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
                Console.WriteLine("" & Environment.NewLine)
            End If
            If other_food_choice_number = 2 Then
                soundPlayer.Play()
                Console.Clear()
                Console.WriteLine("                                       < ITALIAN FOODS LIST >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                              1 -->                      PASTA (4 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              2 -->                      LASAGNA (7.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              3 -->                      RISOTTO (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              4 -->                      BRUCECHETTA (4 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              5 -->                      TIRAMISU (2 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              6 -->                      GELATO (5 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              7 -->                      OSSO BUCO (3.25 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              8 -->                      MINESTRONE (7 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              9 -->                      PANETTONE (3 EUROS)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                     < CHOOSE YOUR ITALIAN FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
                Console.Write("                                                           ")
                italian_food_number = Console.ReadLine()
                If italian_food_number = 1 Then
                    soundPlayer.Play()
                    italian_food_type = "PASTA"
                    italian_food_price = 4
                End If
                If italian_food_number = 2 Then
                    soundPlayer.Play()
                    italian_food_type = "LASAGNA"
                    italian_food_price = 7.5
                End If
                If italian_food_number = 3 Then
                    soundPlayer.Play()
                    italian_food_type = "RISOTTO"
                    italian_food_price = 3
                End If
                If italian_food_number = 4 Then
                    soundPlayer.Play()
                    italian_food_type = "BRUCECHETTA"
                    italian_food_price = 4
                End If
                If italian_food_number = 5 Then
                    soundPlayer.Play()
                    italian_food_type = "TIRAMISU"
                    italian_food_price = 2
                End If
                If italian_food_number = 6 Then
                    soundPlayer.Play()
                    italian_food_type = "GELATO"
                    italian_food_price = 5
                End If
                If italian_food_number = 7 Then
                    soundPlayer.Play()
                    italian_food_type = "OSSO BUCO"
                    italian_food_price = 3.25
                End If
                If italian_food_number = 8 Then
                    soundPlayer.Play()
                    italian_food_type = "MINESTRONE"
                    italian_food_price = 7
                End If
                If italian_food_number = 9 Then
                    soundPlayer.Play()
                    italian_food_type = "PANETTONE"
                    italian_food_price = 3
                End If
                Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR ITALIAN FOOD :)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_first_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_last_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.Clear()
                Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
                Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
                Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
                Console.WriteLine("                                              >   COMMAND      >  " & italian_food_type & Environment.NewLine)
                Console.WriteLine("                                              >    PRICE       >  " & italian_food_price & " EUROS" & Environment.NewLine)
                Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
                Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
                Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
                Console.WriteLine("" & Environment.NewLine)
            End If
            If other_food_choice_number = 3 Then
                soundPlayer.Play()
                Console.Clear()
                Console.WriteLine("                                       < ENGLAND FOODS LIST >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                              1 -->                      FISH AND CHIPS (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              2 -->                      ROAST BEEF (4.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              3 -->                      SHEPHERD'S PIE (2.25 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              4 -->                      BANGERS AND MASH (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              5 -->                      CORNISH PASTY (7 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              6 -->                      TRIFLE (6.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              7 -->                      BUBBLE AND SQUEAK (5.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              8 -->                      SCOTCH EGG (1.5 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              9 -->                      STILTON CHEESE (2 EUROS)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                     < CHOOSE YOUR  FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
                Console.Write("                                                           ")
                england_food_number = Console.ReadLine()
                If england_food_number = 1 Then
                    soundPlayer.Play()
                    england_food_type = "FISH AND CHIPS"
                    england_food_price = 3
                End If
                If england_food_number = 2 Then
                    soundPlayer.Play()
                    england_food_type = "ROAST BEEF"
                    england_food_price = 4.5
                End If
                If england_food_number = 3 Then
                    soundPlayer.Play()
                    england_food_type = "SHEPHERD'S PIE"
                    england_food_price = 2.25
                End If
                If england_food_number = 4 Then
                    soundPlayer.Play()
                    england_food_type = "BANGERS AND MASH"
                    england_food_price = 3
                End If
                If england_food_number = 5 Then
                    soundPlayer.Play()
                    england_food_type = "CORNISH PASTY"
                    england_food_price = 7
                End If
                If england_food_number = 6 Then
                    soundPlayer.Play()
                    england_food_type = "TRIFLE"
                    england_food_price = 6.5
                End If
                If england_food_number = 7 Then
                    soundPlayer.Play()
                    england_food_type = "BUBBLE AND SQUEAK"
                    england_food_price = 5.5
                End If
                If england_food_number = 8 Then
                    soundPlayer.Play()
                    england_food_type = "SCOTCH EGG"
                    england_food_price = 1.5
                End If
                If england_food_number = 9 Then
                    soundPlayer.Play()
                    england_food_type = "STILTON CHEESE"
                    england_food_price = 2
                End If
                Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR ENGLAND FOOD :)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_first_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_last_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.Clear()
                Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
                Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
                Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
                Console.WriteLine("                                              >   COMMAND      >  " & england_food_type & Environment.NewLine)
                Console.WriteLine("                                              >    PRICE       >  " & england_food_price & " EUROS" & Environment.NewLine)
                Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
                Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
                Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
                Console.WriteLine("" & Environment.NewLine)
            End If
            If other_food_choice_number = 4 Then
                soundPlayer.Play()
                Console.Clear()
                Console.WriteLine("                                       < INDIAN FOODS LIST >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                              1 -->                      BUTTER CHICKEN (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              2 -->                      PALAK PANEER (5.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              3 -->                      BIRYANI (2 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              4 -->                      MASALA DOSA (6 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              5 -->                      CHOLE (7 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              6 -->                      TANDOORI CHICKEN (6.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              7 -->                      ROGAN JOSH (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              8 -->                      SAMOSA (2.25 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              9 -->                      GULAB JAMUN (1.5 EUROS)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                     < CHOOSE YOUR  FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
                Console.Write("                                                           ")
                indian_food_number = Console.ReadLine()
                If indian_food_number = 1 Then
                    soundPlayer.Play()
                    indian_food_type = "BUTTER CHICKEN"
                    indian_food_price = 3
                End If
                If indian_food_number = 2 Then
                    soundPlayer.Play()
                    indian_food_type = "PALAK PANEER"
                    indian_food_price = 5.5
                End If
                If indian_food_number = 3 Then
                    soundPlayer.Play()
                    indian_food_type = "BIRYANI"
                    indian_food_price = 2
                End If
                If indian_food_number = 4 Then
                    soundPlayer.Play()
                    indian_food_type = "MASALA DOSA"
                    indian_food_price = 6
                End If
                If indian_food_number = 5 Then
                    soundPlayer.Play()
                    indian_food_type = "CHOLE"
                    indian_food_price = 7
                End If
                If indian_food_number = 6 Then
                    soundPlayer.Play()
                    indian_food_type = "TANDOORI CHICKEN"
                    indian_food_price = 6.5
                End If
                If indian_food_number = 7 Then
                    soundPlayer.Play()
                    indian_food_type = "ROGAN JOSH"
                    indian_food_price = 3
                End If
                If indian_food_number = 8 Then
                    soundPlayer.Play()
                    indian_food_type = "SAMOSA"
                    indian_food_price = 2.25
                End If
                If indian_food_number = 9 Then
                    soundPlayer.Play()
                    indian_food_type = "GULAB JAMUN"
                    indian_food_price = 1.5
                End If
                Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR INDIAN FOOD :)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_first_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_last_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.Clear()
                Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
                Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
                Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
                Console.WriteLine("                                              >   COMMAND      >  " & indian_food_type & Environment.NewLine)
                Console.WriteLine("                                              >    PRICE       >  " & indian_food_price & " EUROS" & Environment.NewLine)
                Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
                Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
                Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
                Console.WriteLine("" & Environment.NewLine)
            End If
            If other_food_choice_number = 5 Then
                soundPlayer.Play()
                Console.Clear()
                Console.WriteLine("                                       < TURKISH FOODS LIST >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                              1 -->                      KEBABS (2 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              2 -->                      BAKLAVA (2.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              3 -->                      MEZE (4 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              4 -->                      KOFTE (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              5 -->                      MANTI (5 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              6 -->                      PIDE (6 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              7 -->                      MENEMEN (3.25 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              8 -->                      LAHMACUN (4 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              9 -->                      ISKENDER KEBAB (4 EUROS)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                     < CHOOSE YOUR  FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
                Console.Write("                                                           ")
                turkish_food_number = Console.ReadLine()
                If turkish_food_number = 1 Then
                    soundPlayer.Play()
                    turkish_food_type = "KEBABS"
                    turkish_food_price = 2
                End If
                If turkish_food_number = 2 Then
                    soundPlayer.Play()
                    turkish_food_type = "BAKLAVA"
                    turkish_food_price = 2.5
                End If
                If turkish_food_number = 3 Then
                    soundPlayer.Play()
                    turkish_food_type = "MEZE"
                    turkish_food_price = 4
                End If
                If turkish_food_number = 4 Then
                    soundPlayer.Play()
                    turkish_food_type = "KOFTE"
                    turkish_food_price = 3
                End If
                If turkish_food_number = 5 Then
                    soundPlayer.Play()
                    turkish_food_type = "MANTI"
                    turkish_food_price = 5
                End If
                If turkish_food_number = 6 Then
                    soundPlayer.Play()
                    turkish_food_type = "PIDE"
                    turkish_food_price = 6
                End If
                If turkish_food_number = 7 Then
                    soundPlayer.Play()
                    turkish_food_type = "MENEMEN"
                    turkish_food_price = 3.25
                End If
                If turkish_food_number = 8 Then
                    soundPlayer.Play()
                    turkish_food_type = "LAHMACUN"
                    turkish_food_price = 4
                End If
                If turkish_food_number = 9 Then
                    soundPlayer.Play()
                    turkish_food_type = "ISKENDER KEBAB"
                    turkish_food_price = 4
                End If
                Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR TURKISH FOOD :)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_first_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_last_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.Clear()
                Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
                Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
                Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
                Console.WriteLine("                                              >   COMMAND      >  " & turkish_food_type & Environment.NewLine)
                Console.WriteLine("                                              >    PRICE       >  " & turkish_food_price & " EUROS" & Environment.NewLine)
                Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
                Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
                Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
                Console.WriteLine("" & Environment.NewLine)
            End If
            If other_food_choice_number = 6 Then
                soundPlayer.Play()
                Console.Clear()
                Console.WriteLine("                                       < FRENCH FOODS LIST >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                              1 -->                      COQ AU VIN (5 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              2 -->                      BOEUF BOURGUIGNON (6.50 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              3 -->                      RATATOUILLE (4 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              4 -->                      BOUIABAISSE (7 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              5 -->                      QUICHE LORRAINE (4 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              6 -->                      CASSOULET (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              7 -->                      ESCARGOT (2.25 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              8 -->                      BOUCHEES A LA REINE (10 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              9 -->                      PISSALADIERE (7 EUROS)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                     < CHOOSE YOUR  FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
                Console.Write("                                                           ")
                french_food_number = Console.ReadLine()
                If french_food_number = 1 Then
                    soundPlayer.Play()
                    french_food_type = "COQ AU VIN"
                    french_food_price = 5
                End If
                If french_food_number = 2 Then
                    soundPlayer.Play()
                    french_food_type = "BOEUF BOURGUIGNON"
                    french_food_price = 6.5
                End If
                If french_food_number = 3 Then
                    soundPlayer.Play()
                    french_food_type = "RATATOUILLE"
                    french_food_price = 4
                End If
                If french_food_number = 4 Then
                    soundPlayer.Play()
                    french_food_type = "BOUIABAISSE"
                    french_food_price = 7
                End If
                If french_food_number = 5 Then
                    soundPlayer.Play()
                    french_food_type = "QUICHE LORRAINE"
                    french_food_price = 4
                End If
                If french_food_number = 6 Then
                    soundPlayer.Play()
                    french_food_type = "CASSOULET"
                    french_food_price = 3
                End If
                If french_food_number = 7 Then
                    soundPlayer.Play()
                    french_food_type = "ESCARGOT"
                    french_food_price = 2.25
                End If
                If french_food_number = 8 Then
                    soundPlayer.Play()
                    french_food_type = "BOUCHEES A LA REINE"
                    french_food_price = 10
                End If
                If french_food_number = 9 Then
                    soundPlayer.Play()
                    french_food_type = "PISSALADIERE"
                    french_food_price = 7
                End If
                Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR FRENCH FOOD :)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_first_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_last_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.Clear()
                Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
                Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
                Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
                Console.WriteLine("                                              >   COMMAND      >  " & french_food_type & Environment.NewLine)
                Console.WriteLine("                                              >    PRICE       >  " & french_food_price & " EUROS" & Environment.NewLine)
                Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
                Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
                Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
                Console.WriteLine("" & Environment.NewLine)
            End If
            If other_food_choice_number = 7 Then
                soundPlayer.Play()
                Console.Clear()
                Console.WriteLine("                                       < AMERICAN FOODS LIST >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                              1 -->                      HOT DOGS (2 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              2 -->                      BBQ RIBS (4.25 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              3 -->                      FRIED CHICKEN (2 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              4 -->                      MACARONI AND CHEESE (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              5 -->                      BARBECUE (1 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              6 -->                      CHILI (3 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              7 -->                      BUFFALO WINGS (7 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              8 -->                      SOUTHERN FRIED CATFISH (7 EUROS)" & Environment.NewLine)
                Console.WriteLine("                              9 -->                      PHILLY CHEESESTEAK (6 EUROS)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                     < CHOOSE YOUR  FOOD NUMBER AND PRESS ENTER >" & Environment.NewLine)
                Console.Write("                                                           ")
                american_food_number = Console.ReadLine()
                If american_food_number = 1 Then
                    soundPlayer.Play()
                    american_food_type = "HOT DOGS"
                    american_food_price = 2
                End If
                If american_food_number = 2 Then
                    soundPlayer.Play()
                    american_food_type = "BBQ RIBS"
                    american_food_price = 4.25
                End If
                If american_food_number = 3 Then
                    soundPlayer.Play()
                    american_food_type = "FRIED CHICKEN"
                    american_food_price = 2
                End If
                If american_food_number = 4 Then
                    soundPlayer.Play()
                    american_food_type = "MACARONI AND CHEESE"
                    american_food_price = 3
                End If
                If american_food_number = 5 Then
                    soundPlayer.Play()
                    american_food_type = "BARBECUE"
                    american_food_price = 1
                End If
                If american_food_number = 6 Then
                    soundPlayer.Play()
                    american_food_type = "CHILI"
                    american_food_price = 3
                End If
                If american_food_number = 7 Then
                    soundPlayer.Play()
                    american_food_type = "BUFFALO WINGS"
                    american_food_price = 7
                End If
                If american_food_number = 8 Then
                    soundPlayer.Play()
                    american_food_type = "SOUTHERN FRIED"
                    american_food_price = 7
                End If
                If american_food_number = 9 Then
                    soundPlayer.Play()
                    american_food_type = "PHILLY CHEESESTEAK"
                    american_food_price = 6
                End If
                Console.WriteLine("                                         (: WAIT 2 MINUTE FOR YOUR AMERICAN FOOD :)" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR FIRST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_first_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.WriteLine("                                            ENTER YOUR LAST NAME PLEASE :)" & Environment.NewLine)
                Console.Write("                                                          ")
                client_last_name = Console.ReadLine()
                Console.WriteLine("" & Environment.NewLine)
                Console.Clear()
                Console.WriteLine("                                                *** YOUR TICKET ***" & Environment.NewLine)
                Console.WriteLine("                                              >  FIRST NAME    >  " & client_first_name & Environment.NewLine)
                Console.WriteLine("                                              >  LAST NAME     >  " & client_last_name & Environment.NewLine)
                Console.WriteLine("                                              >   COMMAND      >  " & american_food_type & Environment.NewLine)
                Console.WriteLine("                                              >    PRICE       >  " & american_food_price & " EUROS" & Environment.NewLine)
                Console.WriteLine("                                              >  WIFI 200m/s   >" & Environment.NewLine)
                Console.WriteLine("                                              >  key: 0010030  >" & Environment.NewLine)
                Console.WriteLine("                                              >  waiter : jhon >" & Environment.NewLine & Environment.NewLine)
                Console.WriteLine("                                                                         H&M RESTAURANT WISH A GOOD DAY TO YOU :)" & Environment.NewLine)
                Console.WriteLine("" & Environment.NewLine)
            End If
        End If
        Console.Read()
    End Sub
End Module