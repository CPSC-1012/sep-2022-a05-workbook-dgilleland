# Submariner - The Game

You captain a submarine in the midst of the war. Your task: sink as many ships as you can without being destroyed yourself.

Behaviours:

- **Submarine** should
    - [ ] Initially be
        - [ ] Docked
        - [ ] Depth of Zero
        - [ ] Crew Count of Zero
        - [ ] Torpedo Count of Zero
        - [ ] Is not ready for launch
    - [ ] Ready Ship For Launch
        - [ ] Replenish Crew
        - [ ] Restock Torpeodos
    - [ ] Launch with
- **Surface Ship** should
    - [ ] Have an estimated tonnage ranging from 100 to 1000, in steps of 100
    - [ ] Be a type of either
        - Transport
        - Armed Escort
- **Game World** should
    - [ ] Consist of a patrol area ranging from 5x5 to 10x10 (square or rectangular)

## Research Notes

- Consider the [coordinate](https://github.com/jaime-olivares/coordinate) repo for a good explanation of making a geocoordinate type.
- Or, use [this one](https://github.com/scottschluer/geolocation) because it is in a NuGet package.
- See this article for [depth terminology](https://en.wikipedia.org/wiki/Submarine_depth_ratings)
- [Movement Cards](https://www.nationalarchives.gov.uk/help-with-your-research/research-guides/merchant-shipping-movement-cards-1939-1945/)
- [WW2 Ship Types](http://www.ww2ships.com/documents/doc0002-ship_types.shtml)