# MonsterEngine
Azure Function Web API for Dungeon Game

This is a serverless API that runs in Azure. I created this function to handle generating the monsters in my game. This is a fairly basic repository. It creates an initial monster for the game and then has a function to generate more monsters, based on the player's level. The idea is to move the logic out of the front-end. I also wanted to create simple API calls that have a single purpose. A game can quickly become complex.

## The Monster Object
The monster inherits several properties from the __Character Class__. The Monster has the following properties:
1. Name: string
1. HitChance: integer
1. Block: integer
1. MaxLife: integer
1. Life: integer
1. HasStrongNose: bool
1. Description: string

The first monster any player will face in the game is Larry the Wimp. The API returns a JSON object for Larry, which looks like this:
```
{
    "maxDamage": 10,
    "description": "Hairy thing with fangs.",
    "hasPowerfulNose": true,
    "minDamage": 5,
    "name": "Larry the Wimp",
    "hitChance": 55,
    "block": 45,
    "maxLife": 50,
    "life": 25
}
```

## GetMonster() endpoint
Retrieving the first monster is done via the GetMonster() function. This is called using the following URL:
http://{baseUrl}/getmonster

## NextMonster() endpoint
Each additional monster is called using the NextMonster() function. This endpoint is a __POST__ endpoint and accepts the __playerLevel__ variable as a URL parameter.
http://{baseUrl}/nextmonster/{playerLevel}

# Pull Requests and Contributions
Contributions and improvements are always welcome, within reason. The simplicity of this API makes for limited opportunities for changes to the code. However, I will consider any clever or funny monster descriptions or monster name options.

Create a branch, add your code, and submit a pull request. I'll do my best to respond quickly.
