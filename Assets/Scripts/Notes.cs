/*  BREAKOUT NOTES
 *  
 *  // set highscore once game ends (Use PlayerPrefs (look at guide that is
        in coding workspace in opera))
    // if lives > 0 --> respawn ball ==> else switch scene to GameOverScene (SceneManager)
    // switch to WinnerScene if score == 105k (SceneManager)

    // Bounds
        bottom screenbounds --> (-12.1, -7, 0), (12.1, -7, 0)
            if BallGO passes this point --> lives--
        left/right bounds --> -12.1x, 12.1x (colliders for walls)
        top bounds --> N/A (will collide with object)

    // Bricks
        12 bricks/row in increments of 2 units on x-axis (x = -12 to 12)
            row (y) increments = 0.75
            Brick totals: 24G, 24B, 24P, 12R
            Max score == 105k
                Green total == 5.4k (225/brick)
                Blue total == 12k (500/brick)
                Purple total == 27.6k (1.15k/brick)
                Red total == 60k (2.5k/brick)
        Green spawn @ 0.75 && 1.5 (y)
            currentScore += 225
        Blue spawn @ 2.25 && 3.0 (y)
            currentScore += 500
        Purple spawn @ 3.75 && 4.5 (y)
            currentScore += 1.15k
        Red spawn @ 5.25 (y)
            currentScore += 2.5k
        (make 

    // Ball spawn @ 0.25, -4.5, 0

    // EXTRAS (if have time after everything else is done)
        for last life, if lives == 1 blink all "life" text black-to-red three times
        when a life is lost, blink all "life" text black-to-red one time
*/
