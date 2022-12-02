def play(hand_one, hand_two):
    
    if(hand_one == hand_two):
        return None

    if (hand_one == "R"):
        return hand_two == "S"

    if (hand_one == "P"):
        return hand_two == "R"

    if (hand_one == "S"):
        return hand_two == "P"

    return None

