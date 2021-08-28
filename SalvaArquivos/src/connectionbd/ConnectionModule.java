package connectionbd;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class ConnectionModule {
    private String host = "localhost";
    private String port = "3306";
    private String db = "clothingStore";
    private String user = "root";
    private String password = "Ng4hwvh26c733kw";
    private Connection connection = null;
    
    public ConnectionModule(){
        doConection();
    }
    
    private void doConection(){
        String url = "jdbc:mysql://address=(host=" + host + ")(port=" + port + ")(user=" + user + ")(password=" + password + ")/" + db + " ? useTimezone=true & serverTimezone=UTC & useSSL=false & allowPublicKeyRetrieval = true";
        try {
            connection = DriverManager.getConnection(url);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null,"ERRO AO SE CONECTAR COM O BANCO DE DADOS\nERRO:" + ex);
            connection = null;
        }
    }
    public Connection getConnectionMySQL(){
        if(connection==null){
            doConection();
            if(connection!=null&&isConnected()){
                return connection;
            }
            return null;
        }
        else if(isConnected()){
            return connection;
        }
        return null;
    }
    public boolean isConnected(){
        if(connection== null){
            return false;
        }
        else{ 
            try {
                if(connection.isValid(0)){
                    return true;
                }
            } 
            catch (SQLException ex) {
                connection = null;
                return false;
            }
        }
        return false;
    }
    public void closeConnection(){
        if(isConnected()){
            try {
                connection.close();
            } catch (SQLException ex) {
                Logger.getLogger(ConnectionModule.class.getName()).log(Level.SEVERE, null, ex);
                connection = null;
            }
        }
    }
}
