package br.com.exception;

public class MsgException extends RuntimeException {

	private static final long serialVersionUID = 1149241039409861914L;

	public MsgException(String msg) {
		super(msg);
	}

	public MsgException(String msg, Throwable cause) {
		super(msg, cause);
	}
}
