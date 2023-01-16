#include <iostream>
#include <string>
#include <clocale>
#include <math.h>
#include <vector>

using namespace std;
class Herbs {
public:
    double calorie, protein, fat, carb;
    string health;

    Herbs(double calories, double proteins, double fats, double carbs)
        :calorie(calories), protein(proteins), fat(fats), carb(carbs) {}

    Herbs(string health) :health(health) {}
};

int comparisonFunction(int choice) //Macronutrient and Numbers comparison of Oregano, Basil and Thyme
{
    string herbsHealth = "\nList of herbs with powerful health benefits: Turmeric, Ginger, Sage, Parsley, Chilli, Cumin, Rosemary\n";
    Herbs Oregano(2.7, 0.1, 0, 0.7);
    Herbs Basil(1.2, 0.2, 0, 0.5);
    Herbs Thyme(101, 6, 1.7, 0.24);
    int mostChoice, compareChoice;

    if (choice == 1)
    {
        if (cin.fail())
        {
            cout << herbsHealth;
            system("pause");
            return 1;
        }


        cout << "Pick a number (1-Calories | 2-Proteins | 3-Fats | 4-Carbs): ";
        cin >> mostChoice;

        if (cin.fail())
        {
            cout << herbsHealth;
            system("pause");
            return 1;
        }

        switch (mostChoice)
        {
        case 1:
            cout << "\nThyme " << Thyme.calorie << "(kcal)\n\n";
            break;
        case 2:
            cout << "\nThyme " << Thyme.protein << "(g) proteins\n\n";
            break;
        case 3:
            cout << "\nThyme " << Thyme.fat << "(g) fats\n\n";
            break;
        case 4:
            cout << "\nOregano " << Oregano.carb << "(g) carbs \n\n";
            break;
        default: cout << "Invalid number, please try again!\n";
            break;
        }
    }
    else if (choice == 2)
    {
        cout << "\nChoose comparison (1-Oregano and Basil | 2-Oregano and Thyme | 3-Basil and Thyme): ";
        cin >> compareChoice;

        if (cin.fail())
        {
            cout << herbsHealth;
            system("pause");
            return 1;
        }

        switch (compareChoice)
        {
        case 1:
            cout << "\nOregano (kcal): " << Oregano.calorie << " proteins(g): " << Oregano.protein << " fats(g): " << Oregano.fat << " carbs(g): " << Oregano.carb << endl;
            cout << "\nBasil (kcal): " << Basil.calorie << " proteins(g): " << Basil.protein << " fats(g): " << Basil.fat << " carbs(g): " << Basil.carb << endl;
            cout << "\nDifference: calories " << Oregano.calorie - Basil.calorie << " proteins(g) " << Basil.protein - Oregano.protein << " fats(g) " << Basil.fat - Oregano.fat << " carbs(g) " << Oregano.carb - Basil.carb << "\n\n";
            break;
        case 2:
            cout << "\nOregano (kcal): " << Oregano.calorie << " proteins(g): " << Oregano.protein << " fats(g): " << Oregano.fat << " carbs(g): " << Oregano.carb << endl;
            cout << "\nThyme (kcal): " << Thyme.calorie << " proteins(g): " << Thyme.protein << " fats(g): " << Thyme.fat << " carbs(g): " << Thyme.carb << endl;
            cout << "\nDifference: calories " << Thyme.calorie - Oregano.calorie << " proteins(g): " << Thyme.protein - Oregano.protein << " fats(g): " << Thyme.fat - Oregano.fat << " carbs(g): " << Oregano.carb - Thyme.carb << "\n\n";
            break;
        case 3:
            cout << "\nBasil (kcal): " << Basil.calorie << " proteins(g): " << Basil.protein << " fats(g): " << Basil.fat << " carbs(g): " << Basil.carb << endl;
            cout << "\nThyme (kcal): " << Thyme.calorie << " proteins(g): " << Thyme.protein << " fats(g): " << Thyme.fat << " carbs(g): " << Thyme.carb << endl;
            cout << "\nDifference: calories " << Thyme.calorie - Basil.calorie << " proteins(g): " << Thyme.protein - Basil.protein << " fats(g): " << Thyme.fat - Basil.fat << " carbs(g): " << Basil.carb - Thyme.carb << "\n\n";
            break;
        default: cout << "\nInvalid number, please try again!\n"; break;
        }
    }
    return 0;
}

int benefitsFunction(int choice) //Health benefits of different herbs
{
    string herbsHealth = "\nList of herbs with powerful health benefits: Turmeric, Ginger, Sage, Parsley, Chilli, Cumin, Rosemary\n";
    Herbs Oregano("Skin soreness, Aching muscles, Asthma, Cramping, Diarrhea, Indigestion, Colds");
    Herbs Basil("Memory loss, Depression, Fasting blood sugar, Mental alertness");
    Herbs Thyme("Bronchitis, Cough, Agitation, Hair loss, Colic, Sore throat");
    int healthChoice;

    if (choice == 3)
    {
        cout << "\nChoose herb (1-Oregano | 2-Basil | 3-Thyme): ";
        cin >> healthChoice;

        if (cin.fail())
        {
            cout << herbsHealth;
            system("pause");
            return 1;
        }

        switch (healthChoice)
        {
        case 1:
            cout << "\nOregano helps with: " << Oregano.health << "\n\n";
            break;
        case 2:
            cout << "\nBasil helps with: " << Basil.health << "\n\n";
            break;
        case 3:
            cout << "\nThyme helps with: " << Thyme.health << "\n\n";
            break;
        default: cout << "Invalid number, please try again!\n"; break;
        }
    }

    return 0;
}

int searchFunction(int choice)
{
    string herbsHealth = "\nList of herbs with powerful health benefits: Turmeric, Ginger, Sage, Parsley, Chilli, Cumin, Rosemary\n";
    string effects[14] = { "Skin soreness", "Aching muscles", "Asthma", "Cramping", "Diarrhea", "Indigestion", "Colds", "Memory loss", "Depression", "Fasting blood sugar", "Mental alertness", "Bronchitis", "Cough", "Agitation"};
    int n;

    if (choice == 4)
    {
        cout << "\nChoose a number of effects you would like to pick (max 17): ";
        
        cin >> n;
        if (cin.fail())
        {
            cout << herbsHealth << endl;
            system("pause");
            return 1;
        }

        cout << "\nPick an effects out of the list (Skin sores | Aching muscles | Asthma | Cramping | Diarrhea | Indigestion | Colds | Memory loss | Depression | Fasting blood sugar | Mental alertness | Bronchitis | Cough | Agitation)\n";
        string healthChoice[14];

        for (int i = 0; i < n; i++)
        {
            cin >> healthChoice[i];

            if (cin.fail())
            {
                cout << herbsHealth << endl;
                system("pause");
                return 1;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < sizeof(healthChoice) / sizeof(healthChoice[0]); j++)
            {
                if (healthChoice[i] == effects[j])
                {
                    cout << effects[j] << endl;
                }
                
            }
        }

    }
    return 0;
}

int main() {
    int decision;

    do {
        cout << "Enter number (1-Macronutrients | 2-Comparison | 3-Health Effects | 4-Effects Search | 0-Exit): ";
        cin >> decision;

       comparisonFunction(decision);
       benefitsFunction(decision);
       searchFunction(decision);

    } while (decision != 0);

    return 0;
}

