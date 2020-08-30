***Settings***
Documentation       Palavras Chaves do projeto

***Keywords***
Dado que desejo comer "${prato}"
    Set Test Variable   ${prato}

Quando submeto meu email "${email}"
    Wait Until Page contains    Buscar Prato    200
    Input Text                  accessibility_id=emailInput     ${email}
    Input Text                  accessibility_id=plateInput     ${prato}
    Click Text                  Buscar Prato


Então devo ver a lista de pratos por tipo
    Wait Until Page Contains    Fome de ${prato}        200
