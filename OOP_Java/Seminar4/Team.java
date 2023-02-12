package OOP_Java.Seminar4;

import java.util.*;

public class Team <E extends Warrior> implements Iterable<E>{
    private List<E> team = new ArrayList<>();
    
    public Team<E> addWarriorToTeam(E person) {
        team.add(person);
        return this;
    }

    @Override
    public Iterator<E> iterator() {
        return team.iterator();
    }

    public int maxTeamRange() {
        int maxRange = 0;
        for (E item : team) {
            if(item instanceof Archer) {
                if(((Archer)item).shotRange() > maxRange) maxRange = ((Archer)item).shotRange();
            }
        }
        return maxRange;
    }

    public int minTeamShield() {
        int minBlock = -1;
        for (E item : team) {
            if(item instanceof Swordman) {
                if(minBlock > -1 && ((Swordman)item).armorAmount() < minBlock) minBlock = ((Swordman)item).armorAmount();
                else minBlock = ((Swordman)item).armorAmount();
            }
        }
        return minBlock;
    }
}
