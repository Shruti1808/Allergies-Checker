# Specs

#### The user enters his/her allergic score which matches the given value for one of the allergen, return the corresponding allergen.
eg, input = 8
output = "You're allergic to strawberries."
#### If the score is greater than 255, return not valid.
eg, input = 255
output = "Not a valid score"
#### If the score is 3, then return egg and peanuts.
eg, score = 3;
output = ["egg", "peanuts"];

#### If the score is greater or equal to 4 and less than 8, then return combinations of eggs, peanuts and shellfish.
eg, score = 6;
output = ["shellfish", "peanuts"]

#### If the score is greater or equal to 8 and less than 16, then return combinations of eggs, peanuts, shellfish and strawberries.
eg, score = 15
output = ["eggs", "peanuts", "shellfish", "strawberries"]

#### If the score is greater or equal to 16 and less than 32, then return combinations of eggs, peanuts, shellfish and strawberries and tomatoes.
eg, score = 31
output =["eggs", "peanuts", "shellfish" and "strawberries" and "tomatoes"]

#### If the score is greater or equal to 32 and less than 64, then return combinations of eggs, peanuts, shellfish and strawberries, tomatoes and chocolate.
eg, score = 63
output = ["eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate"]

#### If the score is greater or equal to 64 and less than 128, then return combinations of eggs, peanuts, shellfish and strawberries, tomatoes, chocolate and pollen.
eg, score = 128
output =["eggs", "peanuts", "shellfish" "strawberries", "tomatoes", "chocolate" "pollen"]
