    body {
      width: 100%;
      overflow: hidden;
      background:whitesmoke
      background-size: cover;
    }
    #board {
      position: relative;
      width: 500px;
      height: 500px;
      margin: 40px auto;
      border: 2px solid white;
      background-color: black;
      overflow: hidden;
    }

    #jet {
      position: absolute;
      width: 40px;
      height: 40px;
      background: url("rocket.png");
      background-size: contain;
      background-repeat: no-repeat;
      left: 50%;
      bottom: 0px;
    }

    .bullets {
      position: absolute;
      bottom: 40px;
      left: 51%;
      width: 20px;
      height: 20px;
      background: url("bullet.png");
      background-size: contain;
      background-repeat: no-repeat;
    }

    .rocks {
      position: absolute;
      top: 0px;
      width: 50px;
      height: 50px;
      background: url("alien.png");
      background-size: contain;
      background-repeat: no-repeat;
    }
    #points {
      position: absolute;
      top: 0px;
      margin: 40px;
      opacity: 0.7;
      font-size: 10em;
      color:black;
    }
