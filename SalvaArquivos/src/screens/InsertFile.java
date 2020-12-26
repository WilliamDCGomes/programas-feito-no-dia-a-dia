package screens;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import connectionbd.ConnectionModule;
import javax.swing.JOptionPane;

/**
 *
 * @author willi_bg
 */
public class InsertFile {
    Connection connection = null;
    PreparedStatement pst = null;
    ResultSet rs = null;
    public InsertFile(){
        ConnectionModule connect = new ConnectionModule();
        connection = connect.getConnectionMySQL();
    }
    public void insertData(String adress){
        String sql = "insert into temporaryAdressChoosed(adress)values(?)";
        try {
            pst = connection.prepareStatement(sql);
            pst.setString(1,adress);
            pst.executeUpdate();
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, e);
        }
    }
}
