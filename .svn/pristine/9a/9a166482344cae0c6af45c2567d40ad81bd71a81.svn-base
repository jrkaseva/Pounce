using Jypeli;

public class FysiikkaPeli2 : PhysicsGame
{
    IntMeter score;
    int totalScore = 0;

    int gameLevel = 1;

    int[] sounds = new int[] { };

    PlatformCharacter player;

    const double SpeedMove = 300;
    const double JumpSpeed = 800;

    /// <summary>
    /// Peli alkaa
    /// </summary>
    public override void Begin()
    {
        MainMenu();
    }


    /// <summary>
    /// NextLevel aliohjelma asettaa gameLevel:n arvon mukaan tason
    /// </summary>
    void NextLevel()
    {
        ClearAll();
        Jatka();

        if (gameLevel == 1) Level1();
        else if (gameLevel == 2) Level2();
        else if (gameLevel == 3) Level3();
        else if (gameLevel == 4) Level4();
        else if (gameLevel == 5) Level5();
        if ((gameLevel == 6) & (totalScore == 14)) SecretLevel();
        else if (gameLevel == 6) VictoryScreen();
        else if (gameLevel == 11) SecretVictoryScreen();
        
    }


    void Level1()
    {
        ClearAll();

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
        LuoPistelaskuri();

        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        PhysicsObject muuri3 = LuoMuuri(muuri1.X + 200.0, muuri1.Y);
        Add(muuri3);
        PhysicsObject vaara1 = LuoVaarat(muuri1.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        PhysicsObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        PhysicsObject vaara3 = LuoVaarat(muuri2.X - 100.0, muuri1.Y - 25.0);
        Add(vaara3);
        PhysicsObject vaara4 = LuoVaarat(muuri2.X + 50.0, muuri1.Y - 25.0);
        Add(vaara4);
        PhysicsObject vaara5 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara5);
        PhysicsObject vaara6 = LuoVaarat(muuri2.X - 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        PhysicsObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);
        GameObject friend = LuoYstava(muuri1.X, muuri1.Y + 75.0);
        Add(friend);
        GameObject friend1 = LuoYstava(muuri2.X, muuri1.Y + 75.0);
        Add(friend1);
        GameObject friend2 = LuoYstava(muuri3.X, muuri1.Y + 150.0);
        Add(friend2);

        gameLevel = 1;
    }


    void Level2()
    {
        ClearAll();

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
        LuoPistelaskuri();

        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        GameObject vaara1 = LuoVaarat(muuri1.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        GameObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        GameObject vaara3 = LuoVaarat(muuri1.X + 200.0, muuri1.Y - 25.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X - 150.0, muuri1.Y - 25.0);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(muuri1.X + 150.0, muuri1.Y - 25.0);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        GameObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);
        GameObject friend = LuoYstava(muuri2.X - 150.0, muuri1.Y + 175.0);
        Add(friend);
        GameObject friend1 = LuoYstava(muuri1.X - 50.0, muuri1.Y - 25.0);
        Add(friend1);

        gameLevel = 2;
    }


    void Level3()
    {
        ClearAll();

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
        LuoPistelaskuri();

        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject vaara1 = LuoVaarat(Level.Left + 300.0, Level.Bottom + 25.0);
        Add(vaara1);
        PhysicsObject muuri1 = LuoMuuri(vaara1.X + 200.0, vaara1.Y + 25.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(vaara1.X + 400.0, vaara1.Y + 25.0);
        Add(muuri2);
        GameObject vaara2 = LuoVaarat(vaara1.X + 100.0, vaara1.Y);
        Add(vaara2);
        GameObject vaara3 = LuoVaarat(muuri1.X + 50.0, vaara1.Y + 200.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X + 50.0, vaara1.Y);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(vaara1.X + 50.0, vaara1.Y);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri2.X - 50.0, vaara1.Y);
        Add(vaara6);
        GameObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);
        GameObject vaara7 = LuoVaarat(muuri1.X + 50.0, vaara1.Y + 150.0);
        Add(vaara7);
        GameObject vaara8 = LuoVaarat(muuri1.X + 50.0, vaara1.Y + 100.0);
        Add(vaara8);
        PhysicsObject taso = LuoTaso(vaara5.X, vaara7.Y);
        Add(taso);
        PhysicsObject taso1 = LuoTaso(muuri1.X, taso.Y + 100.0);
        Add(taso1);
        GameObject friend = LuoYstava(Level.Left + 50.0, vaara1.Y);
        Add(friend);
        GameObject friend1 = LuoYstava(muuri1.X + 50.0, vaara1.Y);
        Add(friend1);
        gameLevel = 3;
    }


    void Level4()
    {
        ClearAll();

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
        LuoPistelaskuri();

        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        PhysicsObject taso = LuoTaso(muuri1.X + 200.0, Level.Bottom + 150.0);
        Add(taso);
        PhysicsObject taso1 = LuoTaso(muuri1.X + 200.0, taso.Y + 200.0);
        Add(taso1);
        PhysicsObject taso2 = LuoTaso(muuri1.X, taso.Y + 100.0);
        Add(taso2);
        GameObject vaara1 = LuoVaarat(muuri2.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        GameObject vaara3 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X - 50.0, muuri1.Y - 25.0);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(muuri2.X + 50.0, muuri1.Y - 25.0);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        GameObject vaara7 = LuoVaarat(muuri2.X + 50.0, muuri1.Y + 25.0);
        Add(vaara7);
        GameObject vaara8 = LuoVaarat(muuri2.X + 50.0, muuri1.Y + 75.0);
        Add(vaara8);
        GameObject vaara9 = LuoVaarat(muuri2.X + 50.0, muuri1.Y + 125.0);
        Add(vaara9);
        GameObject vaara10 = LuoVaarat(muuri2.X + 50.0, muuri1.Y + 175.0);
        Add(vaara10);
        GameObject vaara11 = LuoVaarat(muuri2.X + 50.0, muuri1.Y + 225.0);
        Add(vaara11);
        GameObject friend = LuoYstava(muuri1.X + 100.0, taso2.Y + 25.0);
        Add(friend);
        GameObject friend1 = LuoYstava(muuri1.X + 100.0, taso1.Y + 125.0);
        Add(friend1);
        GameObject friend2 = LuoYstava(muuri1.X - 100.0, taso2.Y + 100.0);
        Add(friend2);
        GameObject friend3 = LuoYstava(taso.X, muuri1.Y -25.0);
        Add(friend3);
        GameObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);

        gameLevel = 4;
    }


    void Level5()
    {
        ClearAll();

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
        LuoPistelaskuri();

        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        PhysicsObject muuri3 = LuoMuuri(muuri1.X + 62.0, Level.Bottom + 310.0);
        Add(muuri3);
        PhysicsObject muuri4 = LuoMuuri(muuri1.X + 62.0, muuri3.Y + 100.0);
        Add(muuri4);
        PhysicsObject muuri5 = LuoMuuri(muuri2.X - 100.0, muuri4.Y + 100.0);
        Add(muuri5);
        PhysicsObject muuri6 = LuoMuuri(muuri5.X, muuri5.Y - 100.0);
        Add(muuri6);
        PhysicsObject muuri7 = LuoMuuri(muuri6.X, muuri6.Y - 100.0);
        Add(muuri7);
        PhysicsObject taso = LuoTaso(Level.Left + 50.0, Level.Bottom + 150.0);
        Add(taso);
        PhysicsObject taso1 = LuoTaso(taso.X, taso.Y + 200.0);
        Add(taso1);
        PhysicsObject taso2 = LuoTaso(muuri1.X - 12.5, taso.Y + 100.0);
        Add(taso2);
        PhysicsObject taso3 = LuoTaso(muuri1.X - 12.5, taso1.Y + 100.0);
        Add(taso3);
        PhysicsObject taso4 = LuoTaso(muuri7.X - 50, muuri7.Y - 40.0);
        Add(taso4);
        PhysicsObject taso5 = LuoTaso(muuri4.X + 50, muuri4.Y - 40.0);
        Add(taso5);
        GameObject vaara1 = LuoVaarat(muuri1.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        GameObject vaara15 = LuoVaarat(muuri1.X - 50.0, muuri1.Y - 25.0);
        Add(vaara15);
        GameObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        GameObject vaara3 = LuoVaarat(muuri2.X - 100.0, muuri1.Y - 25.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X + 50.0, muuri1.Y - 25.0);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri2.X - 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        GameObject vaara7 = LuoVaarat(muuri1.X + 50.0, muuri1.Y + 25.0);
        Add(vaara7);
        GameObject vaara8 = LuoVaarat(muuri1.X + 50.0, muuri1.Y + 75.0);
        Add(vaara8);
        GameObject vaara9 = LuoVaarat(muuri1.X + 50.0, muuri1.Y + 125.0);
        Add(vaara9);
        GameObject vaara10 = LuoVaarat(muuri1.X + 50.0, muuri1.Y + 175.0);
        Add(vaara10);
        GameObject vaara11 = LuoVaarat(muuri2.X + 50.0, muuri1.Y + 25.0);
        Add(vaara11);
        GameObject vaara12 = LuoVaarat(muuri2.X + 50.0, muuri1.Y + 75.0);
        Add(vaara12);
        GameObject vaara13 = LuoVaarat(vaara2.X + 50.0, vaara2.Y);
        Add(vaara13);
        GameObject friend = LuoYstava(taso.X, taso.Y - 25.0);
        Add(friend);
        GameObject friend2 = LuoYstava(taso4.X, taso4.Y + 275.0);
        Add(friend2);
        GameObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);
        GameObject friend1 = LuoYstava(goal.X + 100.0, goal.Y);
        Add(friend1);

        gameLevel = 5;
    }


    void SecretLevel()
    {
        ClearAll();

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();

        Label welcome = new Label(600.0, 200.0);
        welcome.X = Level.Left + 500.0;
        welcome.Y = Level.Top - 200.0;
        welcome.TextColor = Color.Gold;
        welcome.Text = "SAVE YOUR LAST FRIEND: MR. NOOTBERG";
        Add(welcome);

        Level.Background.Color = Color.Silver;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        GameObject vaara1 = LuoVaarat(muuri1.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        GameObject goal = NootBerg(muuri2.X + 150.0, vaara1.Y + 12.5);
        Add(goal);
        GameObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        GameObject vaara3 = LuoVaarat(muuri2.X - 100.0, muuri1.Y - 25.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X + 50.0, muuri1.Y - 25.0);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri2.X - 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        GameObject vaara7 = LuoVaarat(goal.X - 50.0, vaara6.Y);
        Add(vaara7);
        GameObject vaara8 = LuoVaarat(vaara7.X, vaara7.Y + 50);
        Add(vaara8);
        GameObject vaara9 = LuoVaarat(goal.X - 50.0, vaara8.Y + 50);
        Add(vaara9);
        GameObject vaara10 = LuoVaarat(goal.X + 50.0, vaara6.Y);
        Add(vaara10);
        GameObject vaara11 = LuoVaarat(vaara10.X, vaara8.Y);
        Add(vaara11);
        GameObject vaara12 = LuoVaarat(goal.X + 50.0, vaara9.Y);
        Add(vaara12);

        gameLevel = 10;
    }


    /// <summary>
    /// LuoMuuri aliohjelma luo seinän jolla on vuorovaikutusta pelaajan kanssa
    /// </summary>
    /// <param name="x">Muurin sijainti x-akselissa</param>
    /// <param name="y">Muurin sijainti y-akselissa</param>
    /// <returns></returns>
    PhysicsObject LuoMuuri(double x, double y)
    {
        double leveys = 50.0;
        double korkeus = 100.0;
        PhysicsObject muuri = PhysicsObject.CreateStaticObject(leveys, korkeus, Shape.Rectangle);
        muuri.Color = Color.Wheat;
        muuri.X = x;
        muuri.Y = y;
        Add(muuri);
        return muuri;
    }


    PhysicsObject LuoTaso(double x, double y)
    {
        double leveys = 100.0;
        double korkeus = 20.0;
        PhysicsObject taso = PhysicsObject.CreateStaticObject(leveys, korkeus, Shape.Rectangle);
        taso.Color = Color.Wheat;
        taso.X = x;
        taso.Y = y;
        Add(taso);
        return taso;
    }


    /// <summary>
    /// LuoVaarat aliohjelma luo tähden jolla on vuorovaikutusta pelaajan kanssa. Toisessa Aliohjelmassa enemmän vuorovaikutuksesta
    /// </summary>
    /// <param name="x">Tähden sijainti x-akselissa</param>
    /// <param name="y">Tähden sijainti y-akselissa</param>
    /// <returns></returns>
    PhysicsObject LuoVaarat(double x, double y)
    {
        double leveys = 50;
        double korkeus = 50;
        PhysicsObject tahti = PhysicsObject.CreateStaticObject(leveys, korkeus, Shape.Star);
        tahti.X = x;
        tahti.Y = y;
        tahti.Color = Color.DarkGreen;
        tahti.Tag = "tahti";
        Add(tahti);
        return tahti;
    }


    PhysicsObject LuoMaali(double x, double y)
    {
        double w = 50;
        double h = 50;
        PhysicsObject maali = new PhysicsObject(w, h, Shape.Heart);
        maali.X = x;
        maali.Y = y;
        maali.Color = Color.RosePink;
        maali.Tag = "maali";
        Add(maali, 1);
        return maali;
    }


    PhysicsObject LuoYstava(double x, double y)
    {
        double w = 10;
        double h = 10;
        PhysicsObject ystava = new PhysicsObject(w, h, Shape.Ellipse);
        ystava.IgnoresGravity = true;
        ystava.IgnoresCollisionResponse = true;
        ystava.X = x;
        ystava.Y = y;
        ystava.Color = Color.MediumVioletRed;
        ystava.Tag = "ystävä";
        Add(ystava, 1);
        return ystava;
    }


    PhysicsObject NootBerg(double x, double y)
    {
        double r = 75.0;
        PhysicsObject nootberg = new PhysicsObject(r, r, Shape.Rectangle);
        nootberg.Image = LoadImage("pingviini");
        nootberg.X = x;
        nootberg.Y = y;
        nootberg.Tag = "Nootberg";
        nootberg.IgnoresGravity = true;
        nootberg.IgnoresCollisionResponse = true;
        Add(nootberg);
        return nootberg;
    }


    /// <summary>
    /// Kameran asetukset, eli kuinka kamera liikkuu tasoon nähden
    /// </summary>
    void CameraSettings()
    {
        Camera.Follow(player);
        Camera.ZoomFactor = 1.2;
        Camera.StayInLevel = true;
    }


    /// <summary>
    /// Pelaajan asetukset, eli pelaajan muoto ja sijainti pelin alussa
    /// </summary>
    void PlayerSettings()
    {
        double r = 40.0;
        player = new PlatformCharacter(r, r, Shape.Circle);
        player.X = Level.Left + 100;
        player.Y = Level.Bottom + 100;
        player.Color = Color.Maroon;
        AddCollisionHandler(player, "tahti", HitsTahti);
        AddCollisionHandler(player, "maali", InteractWithGoal);
        AddCollisionHandler(player, "ystävä", GetsFriend);
        AddCollisionHandler(player, "Nootberg", InteractWithGoal);
        Add(player);
    }


    /// <summary>
    /// Ohjaimet pelissä, eli pelaajan ohjaimet, sillä muita olioita ei voi ohjata
    /// </summary>
    void Controls()
    {
        Keyboard.Listen(Key.D, ButtonState.Down, Move, "Move left", player, SpeedMove);
        Keyboard.Listen(Key.A, ButtonState.Down, Move, "Move right", player, -SpeedMove);
        Keyboard.Listen(Key.W, ButtonState.Pressed, Leap, "Jump", player, JumpSpeed);

        Keyboard.Listen(Key.Escape, ButtonState.Pressed, OptionMenu, "Asetukset");
    }


    /// <summary>
    /// Aliohjelma Move antaa pelaajalle nopeuden. Move-aliohjelmaa haetaan Controls-aliohjelmassa, jossa määritellään pelaajan liikettä
    /// </summary>
    /// <param name="speed"></param>
    void Move(PlatformCharacter friend, double speed)
    {
        friend = player;
        friend.Walk(speed);
    }


    void Leap(PlatformCharacter friend, double speed)
    {
        friend = player;
        friend.Jump(speed);
    }


    void InteractWithGoal(PhysicsObject player, PhysicsObject goal)
    {
        gameLevel++;
        totalScore += score.Value;
        NextLevel();
    }


    void HitsTahti(PhysicsObject player, PhysicsObject tahti)
    {
        DeathScreen();
    }


    void GetsFriend(PhysicsObject player, PhysicsObject ystava)
    {
        score.Value += 1;
        Remove(ystava);
    }


    void DeathScreen()
    {
        ClearAll();

        MultiSelectWindow deathWindow = new MultiSelectWindow("OOPS, YOU DIED...", "RETRY", "MAIN MENU");
        deathWindow.AddItemHandler(0, NextLevel);
        deathWindow.AddItemHandler(1, MainMenu);
        Add(deathWindow);
    }


    void MainMenu()
    {
        ClearAll();

        gameLevel = 1;

        Level.Background.Color = Color.DarkRed;

        MultiSelectWindow menu = new MultiSelectWindow("POUNCE", "START GAME", "CHOOSE LEVEL", "QUIT");
        menu.AddItemHandler(0, NextLevel);
        menu.AddItemHandler(1, LevelSelect);
        menu.AddItemHandler(2, ExitScreen);
        Add(menu);

    }


    void VictoryScreen()
    {
        ClearAll();

        gameLevel = 1;

        Level.Background.Color = Color.Pink;
        MultiSelectWindow victory = new MultiSelectWindow("YOU WIN! DID YOU SAVE ALL YOUR FRIENDS THOUGH..?", "START AGAIN?", "CHOOSE LEVEL", "MAIN MENU");
        victory.AddItemHandler(0, Level1);
        victory.AddItemHandler(1, LevelSelect);
        victory.AddItemHandler(2, MainMenu);
        Add(victory);
    }


    void LevelSelect()
    {
        ClearAll();

        MultiSelectWindow levels = new MultiSelectWindow("SELECT A LEVEL", "LEVEL 1", "LEVEL 2", "LEVEL 3", "Level 4", "LEVEL 5", "MAIN MENU");
        levels.AddItemHandler(0, Level1);
        levels.AddItemHandler(1, Level2);
        levels.AddItemHandler(2, Level3);
        levels.AddItemHandler(3, Level4);
        levels.AddItemHandler(4, Level5);
        levels.AddItemHandler(5, MainMenu);
        Add(levels);
    }


    void ExitScreen()
    {
        MultiSelectWindow exit = new MultiSelectWindow("ARE YOU SURE YOU WANT TO QUIT?", "YES", "NO");
        exit.AddItemHandler(0, Exit);
        exit.AddItemHandler(1, OptionMenu);
        Add(exit);
    }


    void OptionMenu()
    {
        IsPaused = true;
        MultiSelectWindow options = new MultiSelectWindow("OPTIONS", "RESUME", "RETRY", "MAIN MENU", "EXIT");
        options.AddItemHandler(0, Jatka);
        options.AddItemHandler(1, NextLevel);
        options.AddItemHandler(2, MainMenu);
        options.AddItemHandler(3, ExitScreen);
        Add(options);
    }


    void SecretVictoryScreen()
    {
        ClearAll();

        gameLevel = 1;

        Level.Background.Color = Color.Gold;
        MultiSelectWindow screen = new MultiSelectWindow("YOU SAVED ALL YOUR FRIENDS!", "SELECT LEVEL", "MAIN MENU", "EXIT");
        screen.AddItemHandler(0, LevelSelect);
        screen.AddItemHandler(1, MainMenu);
        screen.AddItemHandler(2, ExitScreen);
        Add(screen);
    }


    void Jatka()
    {
        IsPaused = false;
    }


    void LuoPistelaskuri()
    {
        score = new IntMeter(0);

        Label pisteNaytto = new Label();
        pisteNaytto.X = Screen.Left + 150;
        pisteNaytto.Y = Screen.Top - 125;
        pisteNaytto.TextColor = Color.Black;
        pisteNaytto.Color = Color.Charcoal;
        pisteNaytto.Title = " FRIENDS RESCUED ";

        pisteNaytto.BindTo(score);
        Add(pisteNaytto);
    }
}
